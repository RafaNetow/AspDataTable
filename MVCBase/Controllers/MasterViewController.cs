using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.Object;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Controllers
{
    public class MasterViewController : Controller
    {
        // GET: MasterView
        public ActionResult Index(ObjectModal visitModels)
        {
          
            if (visitModels == null) throw new ArgumentNullException(nameof(visitModels));
            Type currentModel = visitModels.GetType();
            MethodInfo[] mi = currentModel.GetMethods();
            foreach (MethodInfo m in mi) {  
                Console.WriteLine("Method: {0}", m.Name);
        }
           Console.ReadKey();
            return View(new object());
        }
    }
}