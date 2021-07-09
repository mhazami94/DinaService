using System;
using static DataStructure.Tools.Enums;
using Azami.Framework;

namespace DTO
{
    public class Content : DataStructureBase<Content>
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

        private string _alt;
        public string Alt
        {
            get { return _alt; }
            set { base.SetPropertyValue("Alt", value); }
        }

        private string _keyWords;
        public string KeyWords
        {
            get { return _keyWords; }
            set { base.SetPropertyValue("KeyWords", value); }
        }

        private string _slug;
        public string Slug
        {
            get { return _slug; }
            set { base.SetPropertyValue("Slug", value); }
        }

        private byte _place;
        [DbType("tinyint")]
        public byte Place
        {
            get { return _place; }
            set { base.SetPropertyValue("Place", value); }
        }

        private DateTime _publicDate;
        [DbType("datetime")]
        public DateTime PublicDate
        {
            get { return _publicDate; }
            set { base.SetPropertyValue("PublicDate", value); }
        }

        private int _bId;
        [DbType("int")]
        public int BId
        {
            get { return _bId; }
            set { base.SetPropertyValue("BId", value); }
        }


        [DisableAction(DiableAllAction = true)]
        public string Link { get; set; }




    }
}
