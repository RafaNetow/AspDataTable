using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.Container;


namespace MVCBase.Controllers
{
    public class ContainerController : Controller
    {
         Koala2Entities context = new Koala2Entities();
        public ActionResult Index()
        {
            List<Container> containerEntity = new List<Container>();

            try
            {
                containerEntity = (from r in context.Container

                               select r).ToList();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            List<ContainerViewModel> containerModels = new List<ContainerViewModel>();
            foreach (var container in containerEntity)
            {
                containerModels.Add(AutoMapper.Mapper.Map<ContainerViewModel>(container));
            }


            {
                return View(containerModels);
            }
         
            

        }

        // GET: Container/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Container/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Container/Create
        [HttpPost]
        public ActionResult Create(ContainerViewModel model)
        {




                var automapperVesselVisit = AutoMapper.Mapper.Map<Container>(model);
                context.Container.Add(automapperVesselVisit);
                context.SaveChanges();


                return RedirectToAction("Index");

         

        }

        /*  // GET: Container/Edit/5
          public ActionResult Edit(int id)
          {
              var model = servo.SearchContiner(id);

              var automapperModel = AutoMapper.Mapper.Map<ContainerModel>(model);

              return View(automapperModel);
          }

          // POST: Container/Edit/5
          [HttpPost]
          public ActionResult Edit(int id, ContainerModel model)
          {
              try
              {


                  var automapperContainer = AutoMapper.Mapper.Map<Container>(model);


                  servo.EditContainer(automapperContainer);

                  return RedirectToAction("Index");
              }
              catch (Exception e)
              {
                  return View();
              }
          }

          // GET: Container/Delete/5
          public ActionResult Delete(int id)
          {
              return View();
          }

          // POST: Container/Delete/5
          [HttpPost]
          public ActionResult Delete(int id, FormCollection collection)
          {
              try
              {
                  // TODO: Add delete logic here

                  return RedirectToAction("Index");
              }
              catch
              {
                  return View();
              }
          }*/
        [HttpPost]
        public ActionResult MigrateData(int[] IdList)
        {
            if (IdList != null)
            {
                for (int i = 0; i < IdList.Length; i++)
                {
                    int index = IdList[i];
                    Container result = context.Container.SingleOrDefault(x => x.gKey == index);

                    ContainerMirror newContainertMirror = new ContainerMirror
                    {
                       gKey = result.gKey,
                       equipmentNbr = result.equipmentNbr,
                       owner = result.owner,
                       safewt = result.safewt,
                       tareWt = result.tareWt,
                       typeIso = result.typeIso,
                       typeLength = result.typeLength

                    };
                    context.ContainerMirror.Add(newContainertMirror);
                    context.SaveChanges();
                }
            }

            return null;
        }

        public ActionResult Information(int  id)
        {
            Container containerEntity = context.Container.FirstOrDefault(x => x.gKey == id);


             var automapperModel = AutoMapper.Mapper.Map<ContainerViewModel>(containerEntity);

            return View(automapperModel);

        }

        public ActionResult SaveDocuments()
        {

            return null;
        }
        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();

            }
        }
    }

}