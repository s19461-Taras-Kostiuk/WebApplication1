using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDb
    {
        public Doctor_2 createDoctor(Doctor_2 doctor);
        public Doctor_2 updateDoctor(Doctor_2 doctor);
        public Doctor_2 deleteDoctor(int id);
        public IEnumerable<Doctor_2> GetDoctors();


    }
}

