using Azami.Utility;
using BLL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApp.ViewComponents
{
    public class MainNavComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userId = HttpContext.User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            var user = DinaServiceComponent.Instance.UserFacade.Get(userId.ToGuid());
            return await Task.FromResult((IViewComponentResult)View("MainNav", user));
        }

    }
}
