using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.Object;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Controllers
{

    [ atrtributo(FreindlyName = "Soy una vista feliz")]
    public class MasterViewController : Controller
    {
        // GET: MasterView
        Koala2Entities context = new Koala2Entities();
        public ActionResult Index()
        {
            List<VesselVisit> visitEntity = new List<VesselVisit>();

            try
            {
                visitEntity = (from r in context.VesselVisit

                               select r).ToList();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            List<VesselVisitModel> visitModels = new List<VesselVisitModel>();
            foreach (var visit in visitEntity)
            {
                visitModels.Add(AutoMapper.Mapper.Map<VesselVisitModel>(visit));
            }


            Type controllerType = typeof(MasterViewController);
            var customAttributes = controllerType.GetCustomAttributes(typeof(atrtributoAttribute), false);
            var name = customAttributes[0] as atrtributoAttribute;
            ViewBag.ControllerName = name.FreindlyName;

            

            return View(new List<PersonasViewModel> { new PersonasViewModel {Nombre =  "Edwin", Edad = 22, Apellido = "Zelaya"} });
        }
    }

    public class PersonasViewModel
    {
        public string Nombre { get; set; }


        public string Apellido { get; set; }

        [Display(Name = "Edad loca")]
        public int Edad { get; set; }
    }

    public class atrtributoAttribute
         : Attribute
    {
        public string FreindlyName;

        public atrtributoAttribute()
        {
            
        }
    }
}