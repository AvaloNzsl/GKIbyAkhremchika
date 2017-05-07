using GKIbyAkhremchik.BL.News;
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
            var newsmodel = new NewsView();
            return View(newsmodel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminCreateNews(NewsView news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(news);
                return RedirectToAction("AdminNews");
            }
            return View(news);
        }
    }
}