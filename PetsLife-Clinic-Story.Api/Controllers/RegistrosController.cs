using Application.Services;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        public IActionResult Post(RegistroDTO registro)
        {
            return new JsonResult(_service.CreateRegistro(registro));
        }
    }
}
