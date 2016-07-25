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
        public int gKey { get; set; }
        [Required(ErrorMessage = "requerid field")]
        public string equipmentNbr { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string typeIso { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public string owner { get; set; }

        public string CallMember { get; set; }
        [Required(ErrorMessage = "requerid field")]
        public decimal typeLength { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public Nullable<decimal> tareWt { get; set; }

        [Required(ErrorMessage = "requerid field")]
        public Nullable<decimal> safewt { get; set; }

        public string ControlerOwner { get; set; }
        public HttpPostedFileBase[] File { get; set; }
        public bool Imp { get; set; }
    }
}