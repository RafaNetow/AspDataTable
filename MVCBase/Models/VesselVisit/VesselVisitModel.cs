using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MVCBase.Models.VesselVisit
{
    public class VesselVisitModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "requerid field")]
        public string Visit { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string Line { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string VesselName { get; set; }


        public string CallMember { get; set; }
        [Required(ErrorMessage = "requerid field")]
        public string Phase { get; set; }

        public Nullable<DateTime> Ata { get; set; }
        public Nullable<DateTime> Atd { get; set; }
        public Nullable<DateTime> Eta { get; set; }
        public Nullable<DateTime> Etd { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string Serv { get; set; }
        public string ControlerOwner { get; set; }
        public  bool Imp { get; set; }
    }
}