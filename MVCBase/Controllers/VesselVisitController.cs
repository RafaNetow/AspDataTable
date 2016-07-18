using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Controllers
{
    public class VesselVisitController : Controller
    {
        // GET: VesselVisit
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


            {
                return View(visitModels);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
 
        public ActionResult Create(VesselVisitModel model)
        {

            if (ModelState.IsValid)
            {



                var automapperVesselVisit = AutoMapper.Mapper.Map<VesselVisit>(model);
                context.VesselVisit.Add(automapperVesselVisit);
                context.SaveChanges();


                return RedirectToAction("Index", "ContainerAndVesselVisit");

            }
            return RedirectToAction("Index", "ContainerAndVesselVisit");


        }
        /*   public ActionResult Edit(int id)
        {
            var model = servo.SearchContiner(id);

            var automapperModel = AutoMapper.Mapper.Map<ContainerModel>(model);
           
            return View(automapperModel);
        }*/
        public ActionResult Edit(int id)
        {
            VesselVisit VesselVisitEntity = context.VesselVisit.FirstOrDefault(x => x.id == id);


            var automapperModel = AutoMapper.Mapper.Map<VesselVisitModel>(VesselVisitEntity);

            return View(automapperModel);


        }
        [HttpPost]
        public ActionResult Edit(VesselVisitModel model)
        {
            var automapperModel = AutoMapper.Mapper.Map<VesselVisit>(model);
            VesselVisit teacher = context.VesselVisit.SingleOrDefault(x => x.id == automapperModel.id);

            context.Entry(teacher).CurrentValues.SetValues(automapperModel);
            context.SaveChanges();



            return RedirectToAction("Index");


        }
    }
}