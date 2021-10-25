using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WebApp.Helpers
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeRoles : AuthorizeAttribute, IAuthorizationFilter
    {
        private string accessDeniedPath = "/AccessDenied";
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return;
            }
        
            //var userId = user.Claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            //var roles = StablexComponent.Instance.UserRoleFacade.Select(x => x.RoleId, x => x.UserId == userId.ToGuid());
            //var menus = StablexComponent.Instance.RoleMenuFacade.Select(x => x.Menu.Url, x => x.RoleId.In(roles));

            //var url = context.HttpContext.Request.Path.ToString();
            //var currentUrl = url.Split('/').ToList();
            //currentUrl.RemoveAt(currentUrl.Count - 1);
            //var fixedUrl = string.Join('/', currentUrl);
            //var isAccess = menus.Any(x => x.Contains(fixedUrl));
            //if (!isAccess)
            //{
            //    var denied = $"https://{context.HttpContext.Request.Headers["Host"]}{accessDeniedPath}";
            //    context.HttpContext.Response.Redirect(denied);
            //}

        }



    }


}
