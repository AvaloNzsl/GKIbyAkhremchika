using GKIbyAkhremchik.BL.Gallery;
using GKIbyAkhremchik.BL.News;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers
{
    public class HomeController : Controller
    {
        private INewsService _newsService;
        private IGalleryService _galleryService;
        public HomeController(INewsService newsService, IGalleryService galleryService)
        {
            _newsService = newsService;
            _galleryService = galleryService;
        }
        protected internal string school = "school";

        // GET: Home
        public ActionResult HomePage()
        {
            var news = _newsService.GetAll(school);
            return View(news);
        }

        // GET: NewsBlog
        public ActionResult School()
        {
            var news = _newsService.GetAll(school);
            return View(news);
        }

    }
}