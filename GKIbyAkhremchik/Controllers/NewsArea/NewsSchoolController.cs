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
        //private IGalleryService _galleryService;
        public NewsSchoolController(INewsService newsService)
        {
            _newsService = newsService;
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

        public ActionResult UpdateNewsSchoolS(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolByIdWithModel(id);/*GetNewsSchoolById*/
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsSchoolS(/*NewsSchool*/NewsModel news)
        {
            if (ModelState.IsValid)
            {
                _newsService.UpdateNewsWithModel(news);/*UpdateNews*/
                _newsService.Save();
                return RedirectToAction("NewsSchoolPage");
            }
            return View(news);
        }

        public ActionResult DetailNewsSchool(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolById(id);
            return View(newsmodel);
        }

        public ActionResult Delete(int id)
        {
            NewsSchool delete = _newsService.GetNewsSchoolById(id);
            _newsService.DeleteNews(id, school);
            _newsService.Save();

            return RedirectToAction("NewsSchoolPage");
        }
    }
}