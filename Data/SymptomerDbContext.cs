using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SymptomerWebApi.Models;

namespace SymptomerWebApi.Data
{
    public class SymptomerDbContext : DbContext
    {
        public SymptomerDbContext (DbContextOptions<SymptomerDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Symptomer>().HasMany(o => o.Regioners).WithOne(a => a.Symptomer).HasForeignKey(a => a.SymptomerId);
            modelBuilder.SeedData();
        }

        public DbSet<SymptomerWebApi.Models.Symptomer> Symptomer { get; set; }
        public DbSet<SymptomerWebApi.Models.Regioner> Regioners { get; set; }
    }
}
