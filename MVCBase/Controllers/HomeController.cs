using System.Web.Mvc;

namespace MVCBase.Controllers
{    
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            if (User.Identity.Name == null || User.Identity.Name == "")
            {
                return RedirectToAction("Login", "Account");
            }
           

            return View();
        }

       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}