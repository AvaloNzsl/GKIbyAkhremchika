using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModel;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers
{
    public class NewsBlogController : Controller
    {
        // GET: NewsBlog
        //see user
        public ActionResult NewsSchool()
        {
            return View();
        }

        //see admin
        private INewsService _newsService;
        public NewsBlogController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public ActionResult AdminNews()
        {
            var news = _newsService.GetAll();
            return View(news);
        }
        public ActionResult AdminCreateNews()
        {
            //var newsmodel = new NewsView();
            return View(/*newsmodel*/);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminCreateNews(NewsView news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(news);
                _newsService.Save();
                return RedirectToAction("AdminNews");
            }
            return View(news);
        }

        public ActionResult AdminUpdateNews(int id)
        {
            var newsmodel = _newsService.GetNewsById(id);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult AdminUpdateNews(NewsSchool news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(news);
                return RedirectToAction("AdminNews");
            }
            return View(news);
        }


        public ActionResult Delete(int id)
        {
            NewsSchool delete = _newsService.GetNewsById(id);
            _newsService.DeleteNews(id);
            _newsService.Save();

            return RedirectToAction("AdminNews");
        }
    }
}