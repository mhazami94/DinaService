using Azami.Framework;
using DataStructure.Tools;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IContentFacade : IBaseFacade<Content>
    {
        List<Content> GetSiteMapContent(Enums.SliderProject orgin);
    }
}
