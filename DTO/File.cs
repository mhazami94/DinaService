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
            set { base.SetPropertyValue("Id", value); }
        }

        private byte[] _context;
        [DbType("varbinary(MAX)")]
        public byte[] Context
        {
            get { return _context; }
            set { base.SetPropertyValue("Context", value); }
        }

        private string _contextType;
        public string ContextType
        {
            get { return _contextType; }
            set { base.SetPropertyValue("ContextType", value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { base.SetPropertyValue("Title", value); }
        }

        private int _fileSize;
        [DbType("int")]
        public int FileSize
        {
            get { return _fileSize; }
            set { base.SetPropertyValue("FileSize", value); }
        }
    }
}
