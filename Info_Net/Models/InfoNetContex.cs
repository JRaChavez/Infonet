using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Info_Net.Models
{
    public class InfoNetContex : DbContext
    {
    public InfoNetContex()
    : base ("DefaultConnection")
    {

    }

        public System.Data.Entity.DbSet<Info_Net.Models.Publication> Publications { get; set; }
    }
}