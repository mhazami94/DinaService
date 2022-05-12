using DTO;
using System.Collections.Generic;
using static DataStructure.Tools.Enums;

namespace BLL.BO
{
    public class SiteMapBO
    {
        //public List<SiteMap> GetWashSiteMap()
        //{
        //    List<SiteMap> result = new List<SiteMap>();
        //    string url = "http://wash.dinaservice.com";
        //    result.Add(new SiteMap()
        //    {
        //        Link = "http://wash.dinaservice.com",
        //    });
     
        //    result.Add(new SiteMap()
        //    {
        //        Link = "http://wash.dinaservice.com/Articles"
        //    });
        //    List<Content> contents = new ContentBO().Where(c => c.Place == (byte)SliderProject.Wash);
        //    foreach (Content item in contents)
        //    {
        //        SiteMap obj = new SiteMap()
        //        {
        //            Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}"
        //        };
        //        result.Add(obj);
        //        //List<string> keywords = item.KeyWords.Split(',').ToList();


        //        //foreach (string key in keywords)
        //        //{
        //        //    if (key.Contains()) {

        //        //    }
        //        //    SiteMap obj2 = new SiteMap()
        //        //    {
        //        //        Link = $"{url}/Content/Category/{item.Id}/{GetSlug(key)}"
        //        //    };
        //        //    result.Add(obj2);
        //        //}
        //    }
        //    List<Brands> brands = new BrandsBO().GetAll();
        //    foreach (Brands item in brands)
        //    {
        //        SiteMap obj = new SiteMap()
        //        {
        //            Link = $"{url}/تعمیر-لوازم-خانگی/{item.BrandsId}/{GetSlug(item.Slug)}"
        //        };
        //        result.Add(obj);
        //    }

        //    return result;


        //}

        public string GetSlug(string slug)
        {
            slug = slug.Replace(" ", "-");
            return slug;
        }
    }
}
