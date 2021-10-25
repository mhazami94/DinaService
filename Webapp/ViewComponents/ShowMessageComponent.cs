using Azami.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapp.Helpers;

namespace WebApp.ViewComponents
{
    public class ShowMessageComponent : ViewComponent
    {
        private ShowMessage _message;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext != null && HttpContext.Session != null
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("Stablex_Message"))
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("Stablex_Message_Type"))
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("Stablex_Message_Show")))
            {
                _message = new ShowMessage
                {
                    Message = HttpContext.Session.GetString("Stablex_Message"),
                    Type = HttpContext.Session.GetString("Stablex_Message_Type").ToEnum<MessageType>(),
                    Show = true
                };

            }
            else
            {
                _message = new ShowMessage
                {
                    Show = false
                };
            }
            HttpContext.Session.Remove("Stablex_Message");
            HttpContext.Session.Remove("Stablex_Message_Type");
            HttpContext.Session.Remove("Stablex_Message_Show");

            return await Task.FromResult((IViewComponentResult)View("ShowMessage", _message));
        }
    }
}
