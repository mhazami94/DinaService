using System;
using System.Collections.Generic;
using System.Text;
using Azami.Framework;
using Azami.Framework.DbHelper;
using Azami.Utility;
using DTO;

namespace BLL.BO
{
    public sealed class UserBO : BusinessBase<User>
    {
        public override bool Insert(IConnectionHandler connectionHandler, User obj)
        {
            obj.Id = Guid.NewGuid();
            return base.Insert(connectionHandler, obj);
        }
        protected override void CheckConstraint(IConnectionHandler connectionHandler, User obj)
        {
            User user = base.FirstOrDefault(connectionHandler, c => c.Username == obj.Username);
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

    }
}
