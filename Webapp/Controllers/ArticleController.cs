
using BLL;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Webapp.Helpers;

namespace DinaService.Controllers
{
    public class ArticleController : Controller
    {

        [Route("Articles")]
        public async Task<IActionResult> ArticleList()
        {
            var list = await DinaServiceComponent.Instance.ArticleFacade.WhereAsync(x => x.Publish);
            return View(list);
        }

        [Route("/مقالات/{url}")]
        public async Task<IActionResult> Article(string url)
        {
            var article = await DinaServiceComponent.Instance.ArticleFacade.FirstOrDefaultAsync(x => x.Url == $"/{url}");
            return View(article);
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var list = await DinaServiceComponent.Instance.ArticleFacade.GetAllAsync();
            return View(list);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View(new Article());
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Article article, IFormFile image)
        {
            try
            {
                if (!await DinaServiceComponent.Instance.ArticleFacade.InsertAsync(article, image))
                    throw new Exception("Error in Inserting data");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessage(ex.Message, MessageType.Failed);
                return View(article);
            }
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            return View(DinaServiceComponent.Instance.ArticleFacade.Get(id));
        }

        [Authorize]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Article article, IFormFile image)
        {
            try
            {
                if (!await DinaServiceComponent.Instance.ArticleFacade.UpdateAsync(article, image))
                    throw new Exception("Error in Updating data");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessage(ex.Message, MessageType.Failed);
                return View(article);
            }
        }

        [Authorize]
        public IActionResult Details(int id)
        {
            return View(DinaServiceComponent.Instance.ArticleFacade.Get(id));
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            return View(DinaServiceComponent.Instance.ArticleFacade.Get(id));
        }

        [Authorize]
        [ActionName("Delete")]
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            var article = DinaServiceComponent.Instance.ArticleFacade.Get(id);
            try
            {
                if (!await DinaServiceComponent.Instance.ArticleFacade.DeleteAsync(id))
                    throw new Exception("Error in Deleting data");
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                MessageHandler.ShowMessage(ex.Message, MessageType.Failed);
                return View(article);
            }
        }

        //[Route("گازهاي-مورد-استفاده-در-یخچال-سازی/تعمیر-یخچال")]
        //public IActionResult ArticleOne()
        //{
        //    return View();
        //}

        //[Route("تعمیر-برد-یخچال/تعمیر-یخچال")]
        //public IActionResult ArticleTow()
        //{
        //    return View();
        //}

        //[Route("عیب-یابی-و-تعمیر-یخچال/تعمیر-یخچال")]
        //public IActionResult ArticleThree()
        //{
        //    return View();
        //}
    }
}