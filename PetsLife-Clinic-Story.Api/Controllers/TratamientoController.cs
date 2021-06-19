using Application.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetsLife_Clinic_Story.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class TratamientoController
    {
        private readonly ITratamientoService _service;

        public TratamientoController(ITratamientoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(TratamientoDTO tratamiento)
        {
            try
            {
                return new JsonResult(_service.CreateTratamiento(tratamiento)) { StatusCode = 201 };
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }
    }
}