using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


    }
}
