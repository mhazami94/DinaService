using static DataStructure.Tools.Enums;
using System;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    public class Request : DataStructureBase<Request>
    {
        private long _id;
        [Key(true)]
        [DbType("bigint")]
        public long Id
        {
            get { return _id; }
            set { base.SetPropertyValue("Id", value); }
        }

        private string _name;
        [DbType("nvarchar(250)")]
        public string Name
        {
            get { return _name; }
            set { base.SetPropertyValue("Name", value); }
        }

        private string _phone;
        [DbType("nvarchar(11)")]
        public string Phone
        {
            get { return _phone; }
            set { base.SetPropertyValue("Phone", value); }
        }

        private string _address;
        [DbType("nvarchar(MAX)")]
        public string Address
        {
            get { return _address; }
            set { base.SetPropertyValue("Address", value); }
        }

        private int _applicationType;
        [DbType("int")]
        public int ApplicationType
        {
            get { return _applicationType; }
            set { base.SetPropertyValue("ApplicationType", value); }
        }

        private string _message;
        [DbType("nvarchar(MAX)")]
        public string Message
        {
            get { return _message; }
            set { base.SetPropertyValue("Message", value); }
        }

    }
}
