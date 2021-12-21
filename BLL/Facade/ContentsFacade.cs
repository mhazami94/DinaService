using BLL.BO;
using BLL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DataStructure.Tools.Enums;

namespace BLL.Facade
{
    public sealed class ContentsFacade : DinaServiceBaseFacade<Contents>, IContentsFacade
    {

        public string GetSlug(string slug)
        {
            slug = slug.Replace(" ", "-");
            return slug;
        }
        public List<Contents> GetSiteMapContent(SliderProject place)
        {
            List<Contents> list = base.Where(c => c.Place == (byte)place);
            string url = string.Empty;
            if (place != SliderProject.Orgin)
            {
                url = $"http://{place.ToString().ToLower()}.dinaservice.com";
            }
            else
            {
                url = $"http://dinaservice.com";
            }

            foreach (Contents item in list)
            {
                if (string.IsNullOrEmpty(item.Link))
                {
                    item.Link = $"{url}/Content/Items/{item.Id}/{GetSlug(item.Slug)}";
                }
            }
            return list;
        }
        public List<Contents> GetSiteMapContent()
        {
            List<Contents> list = base.GetAll();
            string url = string.Empty;
            foreach (Contents item in list)
            {
                switch (item.Place)
                {
                    case (byte)SliderProject.Orgin:
                        if (string.IsNullOrEmpty(item.Link))
                        {
                            url = "http://dinaservice.com";
                            item.Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}";
                        }
                        break;
                    case (byte)SliderProject.Cool:
                        url = "http://cool.dinaservice.com";
                        item.Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}";
                        break;
                    case (byte)SliderProject.kitchen:
                        url = "http://kitchen.dinaservice.com";
                        item.Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}";
                        break;
                    case (byte)SliderProject.Wash:
                        url = "http://Wash.dinaservice.com";
                        item.Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}";
                        break;
                    case (byte)SliderProject.Electric:
                        url = "http://electric.dinaservice.com";
                        item.Link = $"{url}/{item.Id}/{GetSlug(item.Slug)}";
                        break;

                }
            }
            return list;
        }


        public bool Update(Contents content, IFormFile image)
        {
            if (image != null)
            {
                Files oldfile = new FilesBO().Get(ConnectionHandler, content.FileId);
                Files file = null;
                if (oldfile == null)
                {
                    file = new Files();
                }
                else
                {
                    file = oldfile;
                }

                //file.Context = new byte[image.ContentLength];
                //image.InputStream.Read(file.Context, 0, image.ContentLength);
                //file.ContextType = image.ContentType;
                //file.Title = image.FileName;
                //file.FileSize = image.ContentLength / 1024;
                if (oldfile == null)
                {
                    if (!new FilesBO().Insert(ConnectionHandler, file))
                    {
                        throw new Exception("خطا در ویرایش تصویر");
                    }
                    content.FileId = file.Id;
                }
                else
                {
                    if (!new FilesBO().Update(ConnectionHandler, file))
                    {
                        throw new Exception("خطا در ویرایش تصویر");
                    }
                }


            }


            return new ContentsBO().Update(ConnectionHandler, content);
        }

        public bool Insert(Contents content, IFormFile image)
        {
            if (image == null)
            {
                throw new Exception("لطفا عکس مطلب را انتخاب کنید");
            }

            Files file = new Files
            {
                //Context = new byte[image.ContentLength]
            };
            //image.InputStream.Read(file.Context, 0, image.ContentLength);
            //file.ContextType = image.ContentType;
            //file.Title = image.FileName;
            //file.FileSize = image.ContentLength / 1024;

            if (!new FilesBO().Insert(ConnectionHandler, file))
            {
                throw new Exception("خطا در ثبت تصویر");
            }

            content.FileId = file.Id;
            return new ContentsBO().Insert(ConnectionHandler, content);

        }





        public override bool Insert(Contents obj)
        {
            string url = string.Empty;
            obj.PublicDate = DateTime.Now;


            return new ContentsBO().Insert(ConnectionHandler, obj);
        }



        public List<string> GetKeyWord(string keywords)
        {
            List<string> list = keywords.Split('-').ToList();
            return list;
        }
    }
}
