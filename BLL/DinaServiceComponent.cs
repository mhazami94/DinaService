using BLL.Facade;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class DinaServiceComponent
    {
        private DinaServiceComponent()
        {

        }

        private static DinaServiceComponent _instance;
        public static DinaServiceComponent Instance
        {
            get { return _instance ?? (_instance = new DinaServiceComponent()); }
        }

        public static string ConnectionString { get; set; }

        public IArticleFacade ArticleFacade
        {
            get
            {
                return new ArticleFacade();
            }
        }

        public IBrandsFacade BrandsFacade
        {
            get
            {
                return new BrandsFacade();
            }
        }

        public IContentFacade ContentFacade
        {
            get
            {
                return new ContentFacade();
            }
        }
        public IFileFacade FileFacade
        {
            get
            {
                return new FileFacade();
            }
        }

        public IRequestFacade RequestFacade
        {
            get
            {
                return new RequestFacade();
            }
        }

        public ISliderFacade SliderFacade
        {
            get
            {
                return new SliderFacade();
            }
        }

        public IUserFacade UserFacade
        {
            get
            {
                return new UserFacade();
            }
        }
    }
}
