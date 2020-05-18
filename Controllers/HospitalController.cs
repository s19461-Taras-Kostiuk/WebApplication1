using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{

    [Route("api/doctors")]
    [ApiController]

    public class HospitalController : ControllerBase
    {
        private readonly IDb _service;


        public HospitalController(IDb service)
        {
            _service = service;
        }


  


        //1
        [HttpGet]
        public IActionResult GetDocs()
        {
            return Ok(_service.GetDoctors());
        }



        //2
        [HttpPost]
        public IActionResult addDoctor(Doctor_2 doctor)
        {
            Doctor_2 newDoctor = _service.createDoctor(doctor);
            return Ok(newDoctor);
        }



        //3
        [HttpDelete("{id}")]
        public IActionResult remove(int id)
        {
            Doctor_2 doctor = _service.deleteDoctor(id);
            return Ok(doctor);
        }


        //4
        [HttpPut]
        public IActionResult updateDoctor(Doctor_2 doctor)
        {
            Doctor_2 newDoctor = _service.updateDoctor(doctor);
            return Ok(newDoctor);
        }


    }
}