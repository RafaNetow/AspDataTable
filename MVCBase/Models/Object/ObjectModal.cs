using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MVCBase.Models.Object
{
    public class ObjectModal
    {
        public List<PropertyInfo> PropertiesName = new List<PropertyInfo>();
        public List<ObjectProperties> AllObjects  = new List<ObjectProperties>();
    }
}