using BLL;
using DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Webapp.Helpers;
using WebApp.Helpers;

namespace Webapp.Controllers
{
    public class UserController : Controller
    {
        [AllowAnonymous]
        [Route("/Security/User/Login")]
        public IActionResult Login(string ReturnUrl)
        {
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [AutoValidateAntiforgeryToken]
        [Route("/User/Login")]
        public IActionResult Login(string username, string password, string returnUrl = null)
        {
            try
            {
                //string gRecaptchaResponse = HttpContext.Request.Form["g-recaptcha-response"];
                //var validate = ReCaptchaClass.Validate(gRecaptchaResponse);

                //if (!validate)
                //{
                //    MessageHandler.ShowMessage("لطفا کپچا را صحیح وارد کنید", MessageType.Failed);
                //    return View();
                //}

                if (string.IsNullOrEmpty(username))
                    throw new Exception("نام کاربری را وارد کنید");
                if (string.IsNullOrEmpty(password))
                    throw new Exception("رمزعبور را وارد کنید");

                var user = DinaServiceComponent.Instance.UserFacade.Login(username, password);
                if (user != null)
                {
                    this.SetCookie(user);
                    if (Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return Redirect("/Dashboard");
                }
                else
                {
                    MessageHandler.ShowMessage("نام کاربری یا رمزعبور صحیح نمی باشد", MessageType.Failed);
                    return View();
                }
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessage(ex.Message, MessageType.Failed);
                return View();
            }
        }

        [AllowAnonymous]
        [Route("/User/Signout")]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Security/User/Login");
        }


        private async void SetCookie(Users user)
        {
            var claims = new List<Claim>
                {
                     new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                     new Claim(ClaimTypes.NameIdentifier, user.Username),
                     new Claim("Id",user.Id.ToString()),
                     new Claim(ClaimTypes.Role, "Host"),
                };

          


            var claimsIdentity = new ClaimsIdentity(
                claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                AllowRefresh = true,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(20),
                // The time at which the authentication ticket expires. A
                // value set here overrides the ExpireTimeSpan option of
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }
    }
}
