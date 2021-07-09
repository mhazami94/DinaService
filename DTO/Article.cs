using static DataStructure.Tools.Enums;
using Azami.Framework;
using System;

namespace DTO
{
    [Serializable]
    public class Article : DataStructureBase<Article>
    {
        private string _id;
        [Key(false)]
        public string Id
        {
            get { return _id; }
            set { base.SetPropertyValue("Id", value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { base.SetPropertyValue("Title", value); }
        }

        private string _slug;
        public string Slug
        {
            get { return _slug; }
            set { base.SetPropertyValue("Slug", value); }
        }

        private int _video;
        public int Video
        {
            get { return _video; }
            set { base.SetPropertyValue("Video", value); }
        }

        private string _remark;
        public string Remark
        {
            get { return _remark; }
            set { base.SetPropertyValue("Remark", value); }
        }

        private byte _position;
        public byte Position
        {
            get { return _position; }
            set { base.SetPropertyValue("Position", value); }
        }

        private string _videoDesc;
        public string VideoDesc
        {
            get { return _videoDesc; }
            set { base.SetPropertyValue("VideoDesc", value); }
        }

    }
}
