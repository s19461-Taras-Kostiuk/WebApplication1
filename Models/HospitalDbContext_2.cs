using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Configurations;

namespace WebApplication1.Models
{
 
    public class HospitalDbContext_2 : DbContext
    {
        public DbSet<Doctor_2> Doctor { get; set; }
        public DbSet<Patient_2> Patient { get; set; }
        public DbSet<Prescription_2> Prescription { get; set; }
        public DbSet<Medicament_2> Medicament { get; set; }
        public DbSet<Prescription_Medicament_2> Prescription_Medicament { get; set; }
    
    
    public HospitalDbContext_2(DbContextOptions opt)
            : base(opt)
        {

        }

  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Doctor_Config());
            modelBuilder.ApplyConfiguration(new Medicament_Config());
            modelBuilder.ApplyConfiguration(new Patient_Config());
            modelBuilder.ApplyConfiguration(new Prescription_Config());
            modelBuilder.ApplyConfiguration(new Prescription_Medicament_Config());
        }
        }
}
