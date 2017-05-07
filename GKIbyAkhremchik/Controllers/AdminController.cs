using System.Collections.Generic;
using System.Web.Mvc;
using GKIbyAkhremchik.ViewModel.Model;

namespace GKIbyAkhremchik.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminPage()
        {
            return View();
        }

        public ActionResult AdminUsersList()
        {
            return View();
        }

        public ActionResult AdminNewsEvent()
        {
            return View();
        }
        public ActionResult AdminGalleryPhoto()
        {
            return View();
        }
        public ActionResult AdminGalleryVideo()
        {
            return View();
        }

        public ActionResult ProfileList()
        {
            return View();
        }
    }
}