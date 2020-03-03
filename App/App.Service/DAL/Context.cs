using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using App.Models;

namespace App.Services.DAL

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext")
        {

        }
        public DbSet<Company> Companies { get; set; } 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
