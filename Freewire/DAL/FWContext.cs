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
        public DbSet<EquipmentModel> Equipment { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCategory> CompanyCategories { get; set; }
    }
}