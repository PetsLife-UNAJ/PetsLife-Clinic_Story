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
    public class RegistrosController : ControllerBase
    {
        private readonly IRegistroService _service;

        public RegistrosController(IRegistroService service)
        {
            _service = service;
        }
    }
}
