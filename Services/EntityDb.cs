using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class EntityDb : IDb
    {

        private readonly HospitalDbContext_2 _context;


        public EntityDb(HospitalDbContext_2 context)
        {
            _context = context;
        }

        //1
        public IEnumerable<Doctor_2> GetDoctors()
        {
            return _context.Doctor.ToList();
        }


        //2
        public Doctor_2 createDoctor(Doctor_2 doctor)
        {
            _context.Doctor.Add(doctor);
            _context.SaveChanges();
            return _context.Doctor.Where(d =>
                    d.FirstName == doctor.FirstName && d.LastName == doctor.LastName && d.Email == doctor.Email)
                .FirstOrDefault();
        }

        //3
        public Doctor_2 deleteDoctor(int id)
        {
         
            var doc = _context.Doctor.SingleOrDefault(x => x.IdDoctor == id);


            _context.Remove(doc);


            _context.SaveChanges();

            return doc;
        }

        //4
        public Doctor_2 updateDoctor(Doctor_2 doctor)
        {
          
            var doc = _context.Doctor.SingleOrDefault(x => x.IdDoctor == doctor.IdDoctor);

            doc.FirstName = doctor.FirstName;
            doc.LastName = doctor.LastName;
            doc.Email = doctor.Email;

            _context.SaveChanges();


            return doc;
        }






    }
}
