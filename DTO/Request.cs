using static DataStructure.Tools.Enums;
using System;
using Azami.Framework;

namespace DTO
{
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
        public string Name
        {
            get { return _name; }
            set { base.SetPropertyValue("Name", value); }
        }

        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { base.SetPropertyValue("Phone", value); }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { base.SetPropertyValue("Address", value); }
        }

        private byte _applicationType;
        [DbType("tinyint")]
        public byte ApplicationType
        {
            get { return _applicationType; }
            set { base.SetPropertyValue("ApplicationType", value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { base.SetPropertyValue("Message", value); }
        }

    }
}
