using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class Medicament_Config 
        : IEntityTypeConfiguration<Medicament_2>
    {
        public void Configure(EntityTypeBuilder<Medicament_2> builder)
        {
            builder.HasKey(key => key.IdMedicament);
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Type).HasMaxLength(100).IsRequired();

            var Medicaments = new List<Medicament_2>();
            Medicaments.Add(new Medicament_2 { Description = "hedache", IdMedicament = 1, Name = "nurofen", Type = "pills" });
            Medicaments.Add(new Medicament_2 { Description = "flu", IdMedicament = 2, Name = "superflu", Type = "syrop" });
            Medicaments.Add(new Medicament_2 { Description = "koronavirus", IdMedicament = 3, Name = "covid-19", Type = "syrop" });
            builder.HasData(Medicaments);
        }


        }
}
