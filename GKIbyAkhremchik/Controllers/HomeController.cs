using GKIbyAkhremchik.BL.Gallery;
using GKIbyAkhremchik.BL.News;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers
{
    public class HomeController : Controller
    {
        //initializing objects with access business logic
        private INewsService _newsService;
        private IGalleryService _galleryService;
        public HomeController(INewsService newsService, IGalleryService galleryService)
        {
            _newsService = newsService;
            _galleryService = galleryService;
        }
        //news category
        protected internal string school = "school";
        protected internal string art = "art";
        protected internal string music = "music";

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