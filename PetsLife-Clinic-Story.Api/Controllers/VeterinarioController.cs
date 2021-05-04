using Application.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetsLife_Clinic_Story.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeterinarioController : ControllerBase
    {
        private readonly IVeterinarioService _service;

        public VeterinarioController(IVeterinarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post(VeterinarioDTO veterinarioDTO)
        {
            try
            {
                return new JsonResult(_service.Create(veterinarioDTO));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}