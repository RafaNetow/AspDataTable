﻿using System;
using System.Collections.Generic;
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

            if (ModelState.IsValid)
            {



                var automapperVesselVisit = AutoMapper.Mapper.Map<Container>(model);
                context.Container.Add(automapperVesselVisit);
                context.SaveChanges();


                return RedirectToAction("Index");

            }
            return View(model);

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
    }

}