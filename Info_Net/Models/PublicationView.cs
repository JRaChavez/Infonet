using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Info_Net.Models
{
    public class PublicationView
    {
        [Required(ErrorMessage = "the file {0} is required")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters",
            MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "the file {0} is required")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters",
        MinimumLength = 3)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "the file {0} is required")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters",
        MinimumLength = 3)]
        public string Description { get; set; }

        [Required(ErrorMessage = "the file {0} is required")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Contenido")]
        public string Contenido { get; set; }

        [DataType(DataType.ImageUrl)]
        public HttpPostedFileBase Imagen { get; set; }

   
    }
}