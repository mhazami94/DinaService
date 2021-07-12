using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    public sealed class User : DataStructureBase<User>
    {
        private Guid _id;
        [Key(false)]
        [DbType("uniqueidentifier")]
        public Guid Id
        {
            get { return _id; }
            set { SetPropertyValue("Id", value); }
        }

        private string _firstName;
        [DbType("nvarchar(50)")]
        public string FirstName
        {
            get { return _firstName; }
            set { SetPropertyValue("FirstName", value); }
        }

        private string _lastName;
        [DbType("nvarchar(50)")]
        public string LastName
        {
            get { return _lastName; }
            set { SetPropertyValue("LastName", value); }
        }


        private string _username;
        [DbType("nvarchar(150)")]
        public string Username
        {
            get { return _username; }
            set { SetPropertyValue("Username", value); }
        }

        private string _password;
        [DbType("nvarchar(max)")]
        public string Password
        {
            get { return _password; }
            set { SetPropertyValue("Password", value); }
        }

        #region temp
        [DisableAction(DiableAllAction = true)]
        public string ConfirmPassword { get; set; }
        #endregion temp
    }
}
