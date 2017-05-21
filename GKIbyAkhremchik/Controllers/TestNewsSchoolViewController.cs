using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GKIbyAkhremchik.DAL;

namespace GKIbyAkhremchik.Controllers
{
    public class TestNewsSchoolViewController : Controller
    {
        private GKI_DataEntities db = new GKI_DataEntities();

        // GET: TestNewsSchoolView
        public ActionResult Index()
        {
            var newsSchools = db.NewsSchools.Include(n => n.GalleryVideo).Include(n => n.GalleryPhoto);
            return View(newsSchools.ToList());
        }

        // GET: TestNewsSchoolView/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsSchool newsSchool = db.NewsSchools.Find(id);
            if (newsSchool == null)
            {
                return HttpNotFound();
            }
            return View(newsSchool);
        }

        // GET: TestNewsSchoolView/Create
        public ActionResult Create()
        {
            ViewBag.GalleryVideoId = new SelectList(db.GalleryVideos, "GalleryVideoId", "Title");
            ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title");
            return View();
        }

        // POST: TestNewsSchoolView/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NewsSchoolId,Title,Date,Img_Title,SmallText,FullText,GalleryPhotoId,GalleryVideoId")] NewsSchool newsSchool)
        {
            if (ModelState.IsValid)
            {
                db.NewsSchools.Add(newsSchool);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GalleryVideoId = GetGallery(newsSchool);
            ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title", newsSchool.GalleryPhotoId);
            return View(newsSchool);
        }

        public SelectList GetGallery(NewsSchool newsSchool)
        {
            SelectList video = new SelectList(db.GalleryVideos, "GalleryVideoId", "Title", newsSchool.GalleryVideoId);
            return video;

        }

        // GET: TestNewsSchoolView/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsSchool newsSchool = db.NewsSchools.Find(id);
            if (newsSchool == null)
            {
                return HttpNotFound();
            }
            ViewBag.GalleryVideoId = new SelectList(
                db.GalleryVideos/*база*/,
                "GalleryVideoId"/*имя id*/,
                "Title"/*что выводить списком - тут название галереи*/,
                newsSchool.GalleryVideoId/*модели школы где Галерея из базы школы связывает с Галереей по её Id*/);
            ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title", newsSchool.GalleryPhotoId);
            return View(newsSchool);
        }

        // POST: TestNewsSchoolView/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NewsSchoolId,Title,Date,Img_Title,SmallText,FullText,GalleryPhotoId,GalleryVideoId")] NewsSchool newsSchool)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsSchool).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GalleryVideoId = new SelectList(db.GalleryVideos, "GalleryVideoId", "Title", newsSchool.GalleryVideoId);
            ViewBag.GalleryPhotoId = new SelectList(db.GalleryPhotoes, "GalleryPhotoId", "Title", newsSchool.GalleryPhotoId);
            return View(newsSchool);
        }

        // GET: TestNewsSchoolView/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsSchool newsSchool = db.NewsSchools.Find(id);
            if (newsSchool == null)
            {
                return HttpNotFound();
            }
            return View(newsSchool);
        }

        // POST: TestNewsSchoolView/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsSchool newsSchool = db.NewsSchools.Find(id);
            db.NewsSchools.Remove(newsSchool);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
