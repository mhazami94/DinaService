using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    public class File : DataStructureBase<File>
    {
        private int _id;
        [Key(true)]
        [DbType("int")]
        public int Id
        {
            get { return _id; }
            set { SetPropertyValue("Id", value); }
        }

        private string _name;
        [DbType("nvarchar(100)")]
        public string Name
        {
            get { return _name; }
            set { SetPropertyValue("Name", value); }
        }

        private int _size;
        [DbType("int")]
        public int Size
        {
            get { return _size; }
            set { SetPropertyValue("Size", value); }
        }

        private string _contentType;
        [DbType("nvarchar(500)")]
        public string ContentType
        {
            get { return _contentType; }
            set { SetPropertyValue("ContentType", value); }
        }

        private string _extension;
        [DbType("varchar(10)")]
        public string Extension
        {
            get { return _extension; }
            set { SetPropertyValue("Extension", value); }
        }

        private byte[] _content;
        [DbType("varbinary(MAX)")]
        public byte[] Content
        {
            get { return _content; }
            set { SetPropertyValue("Content", value); }
        }

  
        private DateTime _createDate;
        [DbType("datetime")]
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { SetPropertyValue("CreateDate", value); }
        }
    }
}
