using DataStructure.Tools;
using System;
using Azami.Framework;

namespace DTO
{
    [Serializable]
    public sealed class Slider : DataStructureBase<Slider>
    {
        private int _id;
        [Key(true)]
        [DbType("int")]
        public int Id
        {
            get { return _id; }
            set { base.SetPropertyValue("Id", value); }
        }

        private int _fileId;
        [DbType("int")]
        public int FileId
        {
            get { return _fileId; }
            set { base.SetPropertyValue("FileId", value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { base.SetPropertyValue("Title", value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { base.SetPropertyValue("Description", value); }
        }

        private string _link;
        public string Link
        {
            get { return _title; }
            set { base.SetPropertyValue("Link", value); }
        }

        private byte _place;
        [DbType("tinyint")]
        public byte Place
        {
            get { return _place; }
            set { base.SetPropertyValue("Place", value); }
        }
    }
}
