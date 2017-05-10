using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers.NewsArea
{
    public class NewsArtController : Controller
    {
        // GET: NewsArt
        protected internal string art = "art";
        //see user
        public ActionResult NewsArt()
        {
            return View();
        }

        //see admin
        private INewsService _newsService;
        public NewsArtController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public ActionResult NewsArtPage()
        {
            var news = _newsService.GetAll(art);
            return View(news);
        }

        public ActionResult InsertNewsArt()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNewsArt(NewsView news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(news, art);
                _newsService.Save();
                return RedirectToAction("NewsArtPage");
            }
            return View(news);
        }

        public ActionResult UpdateNewsArt(int id)
        {
            var newsmodel = _newsService.GetNewsArtById(id);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsArt(NewsArt news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(news);
                _newsService.Save();
                return RedirectToAction("NewsArtPage");
            }
            return View(news);
        }


        public ActionResult Delete(int id)
        {
            NewsArt delete = _newsService.GetNewsArtById(id);
            _newsService.DeleteNews(id, art);
            _newsService.Save();

            return RedirectToAction("NewsArtPage");
        }
    }
}