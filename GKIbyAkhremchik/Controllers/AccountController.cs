using System.Web.Mvc;

namespace GKIbyAkhremchik.Controllers
{
    public class AccountController : Controller
    {
        
        // GET: Account
        public ActionResult LogIn()
        {
            return View();
        }
        

        public ActionResult MyProfile()
        {
            return View();
        }
    }
}