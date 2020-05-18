using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class Prescription_Medicament_Config :
        IEntityTypeConfiguration<Prescription_Medicament_2>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament_2> builder)
        {
            builder.HasKey(key => new { key.IdMedicament, key.IdPrescription });
            builder.HasOne(e => e.Medicament).WithMany().HasForeignKey(e => e.IdMedicament);
            builder.HasOne(e => e.Prescription).WithMany().HasForeignKey(e => e.IdPrescription);
            builder.Property(e => e.Dose).IsRequired();
            builder.Property(e => e.Details).HasMaxLength(100).IsRequired();
            var Prescription_Medicaments = new List<Prescription_Medicament_2>();

            Prescription_Medicaments.Add(new Prescription_Medicament_2 { Details = "2 razy na dzien", Dose = 50, IdMedicament = 1, IdPrescription = 1 });
            Prescription_Medicaments.Add(new Prescription_Medicament_2 { Details = "1 raz na tydzien", Dose = 1, IdMedicament = 2, IdPrescription = 2 });
            Prescription_Medicaments.Add(new Prescription_Medicament_2 { Details = "1 raz na dzien", Dose = 3, IdMedicament = 3, IdPrescription = 3 });

            builder.HasData(Prescription_Medicaments);

        }



    }
}
