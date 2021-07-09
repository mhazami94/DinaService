using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Azami.Framework;
using Azami.Framework.DbHelper;
using DTO;
using Microsoft.AspNetCore.Http;
using static DataStructure.Tools.Enums;

namespace BLL.BO
{
    public sealed class ContentBO : BusinessBase<Content>
    {

        protected override void CheckConstraint(IConnectionHandler connectionHandler, Content obj)
        {
            if (string.IsNullOrEmpty(obj.Title))
            {
                throw new Exception("لطفا عنوان مطلب را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.KeyWords))
            {
                throw new Exception("لطفا کلمات کلیدی مطلب را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.Slug))
            {
                throw new Exception("لطفا توصیحات آدرس مطلب را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.Description))
            {
                throw new Exception("لطفا توضیحات مطلب را وارد کنید");
            }

            if (string.IsNullOrEmpty(obj.Alt))
            {
                throw new Exception("لطفا توضیحات تصویر مطلب را وارد کنید");
            }

            if (obj.Place == (byte)SliderProject.None)
            {
                throw new Exception("لطفا عنوان مطلب را وارد کنید");
            }
            string url = string.Empty;
            obj.PublicDate = DateTime.Now;
        }

    }
}
