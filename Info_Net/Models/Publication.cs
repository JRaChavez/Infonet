using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Info_Net.Models
{
    public class Publication
    {
    [Key]
        public int Publication_id { get; set; }
        [Required(ErrorMessage ="the file {0} is required")]
        [StringLength(30,ErrorMessage ="The field {0} can contain maximun {1} and minimum {2} characters",
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
       [Display(Name ="Contenido")]
        public string Contenido { get; set; }

      [DataType(DataType.ImageUrl)]
        public string Imagen { get; set; }

       
    }
}