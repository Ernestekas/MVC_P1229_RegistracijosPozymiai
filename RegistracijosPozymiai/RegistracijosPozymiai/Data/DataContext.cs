using Microsoft.EntityFrameworkCore;
using RegistracijosPozymiai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistracijosPozymiai.Data
{
    public class DataContext : DbContext
    {
        public DbSet<RegAttribute> RegAttributes { get; set; }
        public DbSet<RegValue> RegValues { get; set; }
        //public DbSet<FormedRegistration> FormedRegistrations { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FormedRegistration>()
        //    .HasKey(bc => new { bc.RegAttributeId, bc.RegValueId });

        //}
    }
}
