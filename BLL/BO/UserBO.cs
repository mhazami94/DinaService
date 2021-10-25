using System;
using System.Collections.Generic;
using System.Text;
using Azami.Framework;
using Azami.Framework.DbHelper;
using Azami.Utility;
using DTO;

namespace BLL.BO
{
    public sealed class UserBO : BusinessBase<Users>
    {
        public override bool Insert(IConnectionHandler connectionHandler, Users obj)
        {
            if (obj.Id == null || obj.Id == Guid.Empty)
                obj.Id = Guid.NewGuid();
            return base.Insert(connectionHandler, obj);
        }
        protected override void CheckConstraint(IConnectionHandler connectionHandler, Users obj)
        {
            Users user = base.FirstOrDefault(connectionHandler, c => c.Username == obj.Username);
            if (user != null)
            {
                throw new Exception("کاربر دیگری با این نام کاربری در سامانه وجود دارد");
            }

            if (string.IsNullOrEmpty(obj.FirstName))
            {
                throw new Exception("لطفا نام کاربر را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.LastName))
            {
                throw new Exception("لطفا نام خانوادگی کاربر را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.Password))
            {
                throw new Exception("لطفا رمز عبور کاربر را وارد کنید");
            }

            if (obj.Password != obj.ConfirmPassword)
            {
                throw new Exception("رمز عبور با تکرار رمز عبور مطابقت ندارد");
            }

            obj.Password = StringUtils.HashPassword(obj.Password);
        }


        internal Users Login(IConnectionHandler connectionHandler, string username, string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new KnownException("Password is required");
            if (string.IsNullOrEmpty(username))
                throw new KnownException("Username is required");
            var pass = StringUtils.HashPassword(password);
            return base.FirstOrDefault(connectionHandler, x => x.Username == username && x.Password == pass);
        }

        public override Users Get(IConnectionHandler connectionHandler, params object[] keys)
        {
            var user = base.Get(connectionHandler, keys);
            return user;
        }
    }
}
