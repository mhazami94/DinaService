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
            Publish = false;
            Url = string.Empty;
        }
        private int _id;
        [Key(true)]
        [DbType("int")]
        public int Id
        {
            get { return _id; }
            set { SetPropertyValue("Id", value); }
        }

        //private Guid? _imageId;
        //[IsNullable]
        //[DbType("uniqueidentifier")]
        //public Guid? ImageId
        //{
        //    get { return _imageId; }
        //    set { SetPropertyValue("ImageId", value); }
        //}
     

        private string _title;
        [DbType("nvarchar(250)")]
        public string Title
        {
            get { return _title; }
            set { SetPropertyValue("Title", value); }
        }

        private string _pageTitle;
        [DbType("nvarchar(max)")]
        public string PageTitle
        {
            get { return _pageTitle; }
            set { SetPropertyValue("PageTitle", value); }
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


        private string _metaDescription;
        [DbType("nvarchar(max)")]
        [IsNullable]
        public string MetaDescription
        {
            get { return _metaDescription; }
            set { base.SetPropertyValue("MetaDescription", value); }
        }

        private string _url;
        [DbType("nvarchar(1000)")]
        [IsNullable]
        public string Url
        {
            get { return _url; }
            set { base.SetPropertyValue("Url", value); }
        }

        private bool _publish;
        [DbType("bit")]
        public bool Publish
        {
            get { return _publish; }
            set { base.SetPropertyValue("Publish", value); }
        }




    }
}
