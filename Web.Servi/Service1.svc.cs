using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Web.Servi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        Koala2Entities dbContext = new Koala2Entities();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public bool CreateContainer(Container container)
        {

            dbContext.Container.Add(container);
            dbContext.SaveChanges();

            return true;
        }

        public List<Container> GetAll()
        {

            List<Container> models = new List<Container>();
            try
            {
                models = (from r in dbContext.Container

                          select r).ToList();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }


            return models;
        }




        Container IService1.SearchContiner(int gKey)
        {
            Container c = dbContext.Container.FirstOrDefault(x => x.gKey == gKey);
            return c;

        }

        public bool EditContainer(Container model)
        {
            Container teacher = dbContext.Container.Where(
               x => x.gKey == model.gKey).SingleOrDefault();
            if (teacher != null)
            {
                dbContext.Entry(teacher).CurrentValues.SetValues(model);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }



        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(Container composite)
        {
            throw new NotImplementedException();
        }
       

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
