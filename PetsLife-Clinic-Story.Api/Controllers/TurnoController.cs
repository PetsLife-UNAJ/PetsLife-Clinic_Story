using AccessData.Queries.Repository;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetsLife_Clinic_Story.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnoController : ControllerBase
    {
        private readonly ITurnoService _turnoService;

        public TurnoController(ITurnoService turnoService)
        {
            _turnoService = turnoService;
        }

        [HttpPost]
        public IActionResult Create(TurnoDTO turno)
        {
            try
            {
                return new JsonResult(_turnoService.Create(turno)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllTurnoByFecha([FromQuery] DateTime? fecha)
        {
            try
            {
                return new JsonResult(_turnoService.GetAllByFecha(fecha)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}