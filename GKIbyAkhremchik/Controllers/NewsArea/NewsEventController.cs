using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers.NewsArea
{
    public class NewsEventController : Controller
    {
        // GET: NewsEvent
        protected internal string nEvent = "event";
        //see user
        public ActionResult NewsArt()
        {
            return View();
        }

        //see admin
        private INewsService _newsService;
        public NewsEventController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public ActionResult NewsEventPage()
        {
            var news = _newsService.GetEvent();
            return View(news);
        }

        public ActionResult InsertNewsEvent()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNewsEvent(NewsEventView news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddEvent(news);
                _newsService.Save();
                return RedirectToAction("NewsEventPage");
            }
            return View(news);
        }

        public ActionResult UpdateNewsEvent(int id)
        {
            var newsmodel = _newsService.GetNewsEventById(id);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsEvent(NewsEvent news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(news);
                _newsService.Save();
                return RedirectToAction("NewsEventPage");
            }
            return View(news);
        }


        public ActionResult Delete(int id)
        {
            NewsEvent delete = _newsService.GetNewsEventById(id);
            _newsService.DeleteNews(id, nEvent);
            _newsService.Save();

            return RedirectToAction("NewsEventPage");
        }
    }
}