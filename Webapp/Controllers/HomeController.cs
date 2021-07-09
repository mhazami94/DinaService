using Azami.Utility;
using BLL;
using DataStructure.Tools;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DinaService.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowImage(int id)
        {
            File model = DinaServiceComponent.Instance.FileFacade.Get(id);
            return File(model.Context, "image/jpg"); ;
        }
        public IActionResult GenerateMenu()
        {
            List<Brands> list = DinaServiceComponent.Instance.BrandsFacade.GetAll();
            return PartialView("PVMenu", list);
        }

        public IActionResult ContactUs(int? id, string slug)
        {
            return View();
        }

        public IActionResult AboutUs(int? id, string slug)
        {
            return View();
        }



        public IActionResult RegisterRequest()
        {
            Request obj = new Request();
            return View(obj);
        }
        [HttpPost]
        public IActionResult RegisterRequest(Request request)
        {
            try
            {
                if (!DinaServiceComponent.Instance.RequestFacade.Insert(request))
                {
                    throw new Exception("خطایی در ثبت درخواست شما رخ داده است لطفا مجددا تلاش کنید");
                }
                ViewBag.Message = "درخواست شما با موفقیت صبت شد، همکاران ما در اسرع وقت با شما تماس خواهند گرفت";
                ViewBag.Status = "green";
                ViewBag.AppType = EnumUtils.ConvertEnumToIEnumerable<Enums.ApplicationType>();
                return View(request);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                ViewBag.Status = "red";
                return View(request);
            }
        }
    }
}