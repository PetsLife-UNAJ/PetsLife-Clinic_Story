﻿using Application.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Clinic_Story_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoriaClinicaController : ControllerBase
    {
        private readonly IHistoriaClinicaService _service;

        public HistoriaClinicaController(IHistoriaClinicaService service)
        {
            _service = service;
        }

        [HttpGet("{MascotaId}")]
        public IActionResult GetById(int MascotaId)
        {
            return new JsonResult(_service.GetHistoriaClinicaByMascotaId(MascotaId)) { StatusCode = 200 };
        }
    }
}