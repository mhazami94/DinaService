using Azami.Framework;
using DataStructure.Tools;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IContentsFacade : IBaseFacade<Contents>
    {
        List<Contents> GetSiteMapContent(Enums.SliderProject orgin);
    }
}
