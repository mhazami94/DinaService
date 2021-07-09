using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    public class Brands : DataStructureBase<Brands>
    {
        private int _brandsId;
        [Key(true)]
        [DbType("int")]
        public int BrandsId
        {
            get { return _brandsId; }
            set { base.SetPropertyValue("BrandsId", value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { base.SetPropertyValue("Title", value); }
        }

        private string _link;
        public string Link
        {
            get { return _title; }
            set { base.SetPropertyValue("Link", value); }
        }

        private bool _enable;
        [DbType("bit")]
        public bool Enable
        {
            get { return _enable; }
            set { base.SetPropertyValue("Enable", value); }
        }

        private string _slug;
        public string Slug
        {
            get { return _slug; }
            set { base.SetPropertyValue("Slug", value); }
        }

        private int _fileId;
        [DbType("int")]
        public int FileId
        {
            get { return _fileId; }
            set { base.SetPropertyValue("FileId", value); }
        }

    }
}
