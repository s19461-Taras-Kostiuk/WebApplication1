using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Configurations
{
    public class Doctor_Config
        : IEntityTypeConfiguration<Doctor_2>
    {

        public void Configure(EntityTypeBuilder<Doctor_2> builder)
        {
            builder.HasKey(key => key.IdDoctor);
            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();

            var Doctor = new List<Doctor_2>();
            Doctor.Add(new Doctor_2 { Email = "aaaaa@gmail.com", FirstName = "Anna", LastName = "AAA", IdDoctor = 1 });
            Doctor.Add(new Doctor_2 { Email = "bbbbb@gmail.com", FirstName = "Barbara", LastName = "BBB", IdDoctor = 2 });
            Doctor.Add(new Doctor_2 { Email = "ccccc@gmail.com", FirstName = "Cezary", LastName = "CCC", IdDoctor = 3 });

            builder.HasData(Doctor);


        }
    }
}
