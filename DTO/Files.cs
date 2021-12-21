using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    [Schema("dbo")]
    public sealed class Files : DataStructureBase<Files>
    {
        private Guid _id;
        [Key(false)]
        [DbType("uniqueidentifier")]
        public Guid Id
        {
            get { return _id; }
            set { SetPropertyValue("Id", value); }
        }

        private string _title;
        [DbType("nvarchar(100)")]
        public string Title
        {
            get { return _title; }
            set { base.SetPropertyValue("Title", value); }
        }

        private int _size;
        [DbType("int")]
        public int Size
        {
            get { return _size; }
            set { SetPropertyValue("Size", value); }
        }

        private string _contentType;
        [DbType("nvarchar(50)")]
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

        private byte[] _context;
        [DbType("varbinary(MAX)")]
        public byte[] Context
        {
            get { return _context; }
            set { SetPropertyValue("Context", value); }
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
