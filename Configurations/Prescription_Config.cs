using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class Prescription_Config
     : IEntityTypeConfiguration<Prescription_2>
    {

        public void Configure(EntityTypeBuilder<Prescription_2> builder)
        {
            builder.HasKey(key => key.IdPrescription);
            builder.Property(e => e.Date).IsRequired();
            builder.Property(e => e.DueDate).IsRequired();
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.IdPatient);
            builder.HasOne(e => e.Doctor).WithMany().HasForeignKey(e => e.IdDoctor);

            var Prescriptions = new List<Prescription_2>();

            Prescriptions.Add(new Prescription_2
            {
                Date = Convert.ToDateTime("2006-01-10"),DueDate = Convert.ToDateTime("2023-03-09"),
                IdDoctor = 1,IdPatient = 1,
                IdPrescription = 1
            });

            Prescriptions.Add(new Prescription_2
            {
                Date = Convert.ToDateTime("2007-02-11"),DueDate = Convert.ToDateTime("2024-04-10")                ,
                IdDoctor = 2,IdPatient = 2,
                IdPrescription = 2
            });

            Prescriptions.Add(new Prescription_2
            {
                Date = Convert.ToDateTime("2008-03-12"),DueDate = Convert.ToDateTime("2025-05-11")                ,
                IdDoctor = 3,IdPatient = 3,
                IdPrescription = 3
            });

            builder.HasData(Prescriptions);
        }

    }
}
