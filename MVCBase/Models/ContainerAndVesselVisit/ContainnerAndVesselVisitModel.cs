using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBase.Models.Container;
using MVCBase.Models.VesselVisit;

namespace MVCBase.Models.ContainerAndVesselVisit
{
    public class ContainnerAndVesselVisitModel
    {
        public List<VesselVisitModel> VesselList = new List<VesselVisitModel>();
        public List<ContainerViewModel> ContainerList = new List<ContainerViewModel>();

    }
}