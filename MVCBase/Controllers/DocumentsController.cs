using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBase.Models.Documents;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Controllers
{
    public class DocumentsController : Controller
    {
        Koala2Entities context = new Koala2Entities();
        // GET: Documents
        public ActionResult Index()
        {
            List<Documents>documentstEntity = new List<Documents>();

            try
            {
                documentstEntity = (from r in context.Documents

                               select r).ToList();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            List<DocumentsModel> docModel = new List<DocumentsModel>();

            foreach (var documents in documentstEntity)
            {
             docModel.Add(new DocumentsModel {Name = documents.name, Type = documents.type, Id = documents.id});    
            }
            return PartialView(docModel);
        }

        public FileResult ShowDocuments(int id)
        {
            Documents Docu = context.Documents.FirstOrDefault(x => x.id == id);

            return File(Docu.document, Docu.type);
        }
        
    }
}