using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers.NewsArea
{
    public class NewsMusicalController : Controller
    {
        protected internal string musical = "musical";
        // GET: NewsBlog
        //see user
        public ActionResult NewsSchool()
        {
            return View();
        }

        //see admin
        private INewsService _newsService;
        public NewsMusicalController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public ActionResult NewsMusicalPage()
        {
            var news = _newsService.GetAll(musical);
            return View(news);
        }

        public ActionResult InsertNewsMusical()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNewsMusical(NewsModel news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(news, musical);
                _newsService.Save();
                return RedirectToAction("NewsMusicalPage");
            }
            return View(news);
        }

        public ActionResult UpdateNewsMusical(int id)
        {
            var newsmodel = _newsService.GetNewsMusicalById(id);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsMusical(NewsMusical news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(news);
                _newsService.Save();
                return RedirectToAction("NewsMusicalPage");
            }
            return View(news);
        }


        public ActionResult Delete(int id)
        {
            NewsMusical delete = _newsService.GetNewsMusicalById(id);
            _newsService.DeleteNews(id, musical);
            _newsService.Save();

            return RedirectToAction("NewsMusicalPage");
        }
    }
}