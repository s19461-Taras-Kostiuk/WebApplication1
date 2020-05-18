using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class Patient_Config
        : IEntityTypeConfiguration<Patient_2>
    {
        public void Configure(EntityTypeBuilder<Patient_2> builder)
        {

            builder.HasKey(key => key.IdPatient);
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.BirthDate).IsRequired();
           
            var Patient = new List<Patient_2>();

            Patient.Add(new Patient_2 { BirthDate = Convert.ToDateTime("2001-06-10"), FirstName = "Tokio", LastName = "Ja", IdPatient = 1 }); ;
            Patient.Add(new Patient_2 { BirthDate = Convert.ToDateTime("2000-07-11"), FirstName = "Denver", LastName = "Ty", IdPatient = 2 }); ;
            Patient.Add(new Patient_2 { BirthDate = Convert.ToDateTime("2002-08-12"), FirstName = "Berlin", LastName = "On", IdPatient = 3 }); ;

            builder.HasData(Patient);

        }
    }
}
