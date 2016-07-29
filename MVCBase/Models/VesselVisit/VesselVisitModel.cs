using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MVCBase.Models.VesselVisit
{
    public class VesselVisitModel
    {
        [DisplayName("Id33")]
        [Display(Name = "DisplayId")]
        
        public int Id { get; set; }


        [Required(ErrorMessage = "requerid field")]
        [DisplayName("Vesel Visit")]
        public string Visit { get; set; }

        [Required(ErrorMessage = "requerid field")]
        [DisplayName("Line2")]
        public string Line { get; set; }

        [Required(ErrorMessage = "requerid field")]
        [DisplayName("Name")]
        public string VesselName { get; set; }


      
        [Required(ErrorMessage = "requerid field")]
        [DisplayName("Phase of Vessel")]
        public string Phase { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<DateTime> Ata { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<DateTime> Atd { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<DateTime> Eta { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<DateTime> Etd { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string Serv { get; set; }

  
        public HttpPostedFileBase []File { get; set; }
        public  bool Imp { get; set; }
    }
}