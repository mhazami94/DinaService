using BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.ViewComponents
{
    public class MenuComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Brands> list = DinaServiceComponent.Instance.BrandsFacade.GetAll();
            return await Task.FromResult((IViewComponentResult)View("Menu", list));
        }
    }
}
