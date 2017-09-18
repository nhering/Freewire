using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Freewire.Models;
using System.Data.Entity;

namespace Freewire.DAL
{
    public class FWContext : ApplicationDbContext
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        public DbSet<EquipmentModel> Equipment { get; set; }
    }
}