using AccessData.Queries.Repository;
using Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace PetsLife_Clinic_Story.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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

        [HttpGet("{VeterinarioId}")]
        public IActionResult GetTurnosByVeterinario([FromRoute] int VeterinarioId)
        {
            try
            {
                return new JsonResult(_turnoService.GetTurnosByVeterinarioId(VeterinarioId)) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{TurnoId}")]
        public IActionResult DeleteTurno([FromRoute] int TurnoId)
        {
            try
            {
                _turnoService.DeleteTurnoById(TurnoId);
                return new JsonResult("Se ha eliminado el turno") { StatusCode = 200 };
            }
            catch (Exception e)
            { return BadRequest(e.Message); }
        }
    }
}