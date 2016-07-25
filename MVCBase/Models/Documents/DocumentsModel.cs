using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBase.Models.Documents
{
    public class DocumentsModel
    {
        public int Id { get; set; }
        [Required]
        public HttpPostedFileBase File { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] FileBytes { get; set; }
    }
}