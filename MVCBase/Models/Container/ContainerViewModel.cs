using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBase.Models.Container
{
    public class ContainerViewModel
    {

        [Key]
        public int GKey { get; set; }
        [Required(ErrorMessage = "requerid field")]
        public string EquipmentNbr { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string TypeIso { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string Owner { get; set; }


        [Required(ErrorMessage = "requerid field")]
        public decimal TypeLength { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public Nullable<decimal> TareWt { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public Nullable<decimal> Safewt { get; set; }

    
        public HttpPostedFileBase[] File { get; set; }
        public bool Imp { get; set; }
    }
}