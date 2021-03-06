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

        public IContentsFacade ContentFacade
        {
            get
            {
                return new ContentsFacade();
            }
        }
        public IFilesFacade FileFacade
        {
            get
            {
                return new FilesFacade();
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
