
using Microsoft.AspNetCore.Mvc;

namespace DinaService.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Articles

        [Route("Articles")]
        public IActionResult ArticleList()
        {
            return View();
        }

        [Route("گازهاي-مورد-استفاده-در-یخچال-سازی/تعمیر-یخچال")]
        public IActionResult ArticleOne()
        {
            return View();
        }

        [Route("تعمیر-برد-یخچال/تعمیر-یخچال")]
        public IActionResult ArticleTow()
        {
            return View();
        }

        [Route("عیب-یابی-و-تعمیر-یخچال/تعمیر-یخچال")]
        public IActionResult ArticleThree()
        {
            return View();
        }
    }
}