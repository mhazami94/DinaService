using Azami.Utility;
using BLL;
using DataStructure.Tools;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Webapp.Models;

namespace DinaService.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public IActionResult ShowImage(int id)
        //{
        //    File model = DinaServiceComponent.Instance.FileFacade.Get(id);
        //    return File(model.Context, "image/jpg"); ;
        //}
        public IActionResult GenerateMenu()
        {
            List<Brands> list = DinaServiceComponent.Instance.BrandsFacade.GetAll();
            return PartialView("PVMenu", list);
        }

        [HttpGet("/تماس-باما")]
        public IActionResult ContactUs(int? id, string slug)
        {
            return View();
        }

        [HttpGet("/درباره-ما")]
        public IActionResult AboutUs(int? id, string slug)
        {
            return View();
        }

        [Route("filehanlder/{id}")]
        public IActionResult FileHandler(int id)
        {
            Files model = DinaServiceComponent.Instance.FileFacade.Get(id);
            return File(model.Context, model.ContentType);
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

        [HttpGet("/خدمات-مشاوره")]
        public IActionResult ConsultantServices()
        {
            return View();
        }

        [HttpGet("/تعمیر-لباسشویی")]
        public IActionResult WashingMachine()
        {
            return View();
        }

        [HttpGet("/تعمیر-ظرفشویی")]
        public IActionResult DishWasher()
        {
            return View();
        }

        [HttpGet("/تعمیر-یخچال")]
        public IActionResult fridge()
        {
            return View();
        }
    }
}