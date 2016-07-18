using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.Container;
using MVCBase.Models.ContainerAndVesselVisit;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Controllers
{
    public class ContainerAndVesselVisitController : Controller
    {
        // GET: ContainerAndVesselVisit
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

            ContainnerAndVesselVisitModel model = new ContainnerAndVesselVisitModel();


            List<Container> containEntity = new List<Container>();
            try
            {
                containEntity = (from r in context.Container

                    select r).ToList();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            List<ContainerViewModel> containtModels = new List<ContainerViewModel>();
            foreach (var contai in containEntity)
            {
               
                containtModels.Add(AutoMapper.Mapper.Map<ContainerViewModel>(contai));
            }
            model.VesselList = visitModels;
       
            model.ContainerList = containtModels;
       
            return View(model);
        }
       
    }
}