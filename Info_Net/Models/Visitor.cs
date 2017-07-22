using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Info_Net.Models
{
    public class Visitor
    {
    [Key]
        public int Visitor_id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Motivo { get; set; }
        public string Mensaje { get; set; }
    }
}