using static DataStructure.Tools.Enums;
using Azami.Framework;
using System;

namespace DTO
{
    [Serializable]
    public class Article : DataStructureBase<Article>
    {
        public Article()
        {
            Enabled = false;
        }
        private int _id;
        [Key(true)]
        [DbType("int")]
        public int Id
        {
            get { return _id; }
            set { SetPropertyValue("Id", value); }
        }

        private int _imageId;
        [DbType("uniqueidentifier")]
        public int ImageId
        {
            get { return _imageId; }
            set { SetPropertyValue("ImageId", value); }
        }
        [Assosiation(PropName = "ImageId")]
        public File Image { get; set; }


        private string _title;
        [DbType("nvarchar(50)")]
        public string Title
        {
            get { return _title; }
            set { SetPropertyValue("Title", value); }
        }

        private string _abstract;
        [DbType("nvarchar(MAX)")]
        public string Abstract
        {
            get { return _abstract; }
            set { SetPropertyValue("Abstract", value); }
        }

        private string _context;
        [IsNullable]
        [DbType("nvarchar(MAX)")]
        public string Context
        {
            get { return _context; }
            set { SetPropertyValue("Context", value); }
        }

        private bool _enabled;
        [DbType("bit")]
        public bool Enabled
        {
            get { return _enabled; }
            set { SetPropertyValue("Enabled", value); }
        }

        private byte _order;
        [DbType("tinyint")]
        public byte Order
        {
            get { return _order; }
            set { SetPropertyValue("Order", value); }
        }

      
        private int _views;
        [DbType("int")]
        public int Views
        {
            get { return _views; }
            set { base.SetPropertyValue("Views", value); }
        }

        private DateTime _registerDate;
        [DbType("datetime")]
        public DateTime RegisterDate
        {
            get { return _registerDate; }
            set { base.SetPropertyValue("RegisterDate", value); }
        }

    }
}
