using GKIbyAkhremchik.BL.Gallery;
using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.ViewModel.NewsModels;
using System.IO;
using System.Web;
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
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList();
            ViewBag.GalleryVideoId = _galleryService.GetVideosList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertNewsSchool(NewsModel newsmodel, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null) newsmodel.Img_Title = upload.FileName;
                _newsService.AddNews(newsmodel, school);
                _newsService.Save();

                if (upload != null && newsmodel.Date != null && newsmodel.Title != null)
                {
                    string path = _newsService.PathCreate(newsmodel, upload, school);
                    Directory.CreateDirectory(Server.MapPath(path));
                    upload.SaveAs(Server.MapPath(path + upload.FileName));
                }

                return RedirectToAction("NewsSchoolPage");
            }
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList(newsmodel);
            ViewBag.GalleryVideoId = _galleryService.GetVideosList(newsmodel);
            return View(newsmodel);
        }

        public ActionResult UpdateNewsSchool(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolById(id, school);
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList(newsmodel);
            ViewBag.GalleryVideoId = _galleryService.GetVideosList(newsmodel);
            return View(newsmodel);
        }
        [HttpPost]
        public ActionResult UpdateNewsSchool(NewsModel newsmodel, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null) {
                    string path = _newsService.PathCreate(newsmodel, upload, school);
                    FileInfo file = new FileInfo(Server.MapPath(path + newsmodel.Img_Title));
                    if (!(bool)Directory.Exists(Server.MapPath(path)))
                    {
                        Directory.CreateDirectory(Server.MapPath(path));
                    }
                    else if (file.Exists)
                    {
                        file.Delete();
                    }
                    upload.SaveAs(Server.MapPath(path + upload.FileName));
                    newsmodel.Img_Title = upload.FileName;
                }
                _newsService.UpdateNews(newsmodel, school);
                _newsService.Save();
                return RedirectToAction("NewsSchoolPage");
            }
            ViewBag.GalleryPhotoId = _galleryService.GetPhotosList(newsmodel);
            ViewBag.GalleryVideoId = _galleryService.GetVideosList(newsmodel);
            return View(newsmodel);
        }

        public ActionResult DetailNewsSchool(int id)
        {
            var newsmodel = _newsService.GetNewsSchoolById(id, school);
            ViewBag.Path = _newsService.Path(newsmodel);
            return View(newsmodel);
        }

        public ActionResult Delete(int id)
        {
            NewsModel delete = _newsService.GetNewsSchoolById(id, school);
            _newsService.DeleteNews(id, school);
            _newsService.Save();

            return RedirectToAction("NewsSchoolPage");
        }
    }
}