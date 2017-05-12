using GKIbyAkhremchik.BL.Gallery;
using GKIbyAkhremchik.BL.News;
using GKIbyAkhremchik.DAL;
using GKIbyAkhremchik.ViewModel.GalleryViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers.GalleryArea
{
    public class GalleryVideoController : Controller
    {
        protected internal string galleryName = "video";
        // GET: GalleryVideo
        public ActionResult VideoGallery()
        {
            return View();
        }

        //see admin
        //private INewsService _newsService;
        private IGalleryService _galleryService;
        public GalleryVideoController(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public ActionResult VideoGalleryPage()
        {
            var gallery = _galleryService.GetGalleryVideo();
            return View(gallery);
        }
        public ActionResult InsertVideoGallery()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InsertVideoGallery(GalleryVideoView gallery)
        {
            if (ModelState.IsValid)
            {
                _galleryService.AddGallery(gallery);
                _galleryService.Save();
                return RedirectToAction("VideoGalleryPage");
            }
            return View(gallery);
        }
        public ActionResult UpdateVideoGallery(int id)
        {
            var gallery = _galleryService.GetGalleryVideoById(id);
            return View(gallery);
        }
        [HttpPost]
        public ActionResult UpdateVideoGallery(GalleryVideo gallery)
        {
            if (ModelState.IsValid)
            {
                _galleryService.UpdateGallery(gallery);
                _galleryService.Save();
                return RedirectToAction("VideoGalleryPage");
            }
            return View(gallery);
        }
        public ActionResult Delete(int id)
        {
            GalleryVideo delete = _galleryService.GetGalleryVideoById(id);
            _galleryService.DeleteGallery(id, galleryName);
            _galleryService.Save();

            return RedirectToAction("VideoGalleryPage");
        }
    }
}