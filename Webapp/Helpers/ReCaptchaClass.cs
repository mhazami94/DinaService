using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Helpers
{
    public class ReCaptchaClass
    {
        public static bool Validate(string EncodedResponse)
        {
            var client = new System.Net.WebClient();

            string PrivateKey = "6Lcbx3YaAAAAAAV9uyuxrpU2qA2sMJhaGREdSEsg";

            var GoogleReply = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", PrivateKey, EncodedResponse));

            var captchaResponse = Newtonsoft.Json.JsonConvert.DeserializeObject<reCaptchaResponse>(GoogleReply);

            return captchaResponse.Success;
        }
    }
}
