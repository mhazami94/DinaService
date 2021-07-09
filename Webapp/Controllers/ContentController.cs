using BLL;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace DinaService.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category(int? id, string slug)
        {
            Brands brand = DinaServiceComponent.Instance.BrandsFacade.Get(id.Value);
            return View(brand);
        }

        //[Route("Article/{id}")]
        public IActionResult Article(string id)
        {
            Article article = DinaServiceComponent.Instance.ArticleFacade.Get(id);
            return View(article);
        }



    }
}