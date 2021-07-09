using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapp.Helpers
{
    internal static class MessageHandler
    {
        private static IHttpContextAccessor httpContextAccessor;
        public static void SetHttpContextAccessor(IHttpContextAccessor accessor)
        {
            httpContextAccessor = accessor;
        }
        public static void ShowMessage(string message = "", MessageType type = MessageType.Default)
        {
            if (string.IsNullOrEmpty(message))
                return;
            httpContextAccessor.HttpContext.Session.SetString("Dina_Message", message);
            httpContextAccessor.HttpContext.Session.SetString("Dina_Message_Type", type.ToString());
            httpContextAccessor.HttpContext.Session.SetString("Dina_Message_Show", "true");
        }

    }
    public enum MessageType : byte
    {
        Default = 1,
        Success = 2,
        Failed = 3,
        Warning = 4,
    }

    public class ShowMessage
    {
        public string Message { get; set; }
        public MessageType Type { get; set; }
        public bool Show { get; set; }
    }
}
