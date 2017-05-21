using GKIbyAkhremchik.BL.Gallery;
using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.NewsModels;
using GKIbyAkhremchik.ViewModel.NewsViewModel;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers.NewsArea
{
    public class NewsSchoolController : Controller
    {
        protected internal string school = "school";
        // GET: NewsBlog
        public ActionResult NewsSchool()
        {
            return View();
        }

        // GET: NewsBlog by Admin
        private INewsService _newsService;
        private IGalleryService _galleryService;
        public NewsSchoolController(INewsService newsService, IGalleryService galleryService)
        {
            _newsService = newsService;
            _galleryService = galleryService;
        }
        public ActionResult NewsSchoolPage()
        {
            var news = _newsService.GetAll(school);
            return View(news);
        }

        public ActionResult InsertNewsSchool()
        {
            //ViewBag.GalleryVideoId = new SelectList(_galleryService.GetGalleryVideo(), "GalleryVideoId", "Title");
            //ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNewsSchool(NewsView news)
        {
            if (ModelState.IsValid)
            {
                _newsService.AddNews(news, school);
                _newsService.Save();
                return RedirectToAction("NewsSchoolPage");
            }
            //ViewBag.GalleryVideoId = new SelectList(_galleryService.GetGalleryVideo(), "GalleryVideoId", "Title", _galleryService.GetGalleryVideo());
            //ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title", newsSchool.GalleryPhotoId);
            return View(news);
        }
        
        public ActionResult UpdateNewsSchool(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolById(id);
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList(newsmodel);
            ViewBag.GalleryVideoId = _galleryService.GetVideosList(newsmodel);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsSchool(NewsModel news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNews(news);
                _newsService.Save();
                return RedirectToAction("NewsSchoolPage");
            }
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList(news);
            ViewBag.GalleryVideoId = _galleryService.GetVideosList(news);
            return View(news);
        }

        public ActionResult DetailNewsSchool(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolById(id);
            return View(newsmodel);
        }

        public ActionResult Delete(int id)
        {
            NewsModel delete = _newsService.GetNewsSchoolById(id);
            _newsService.DeleteNews(id, school);
            _newsService.Save();

            return RedirectToAction("NewsSchoolPage");
        }
    }
}