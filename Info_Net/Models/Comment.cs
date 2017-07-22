using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Info_Net.Models
{
    public class Comment
    {
    [Key]
        public int comment_id { get; set; }
        public string NomVisit { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public int NumPubli { get; set; }
    }
}