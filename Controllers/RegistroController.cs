using Desafio.Models;
using Desafio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Desafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly IRegistroService _registroService;

        public RegistroController(IRegistroService registroService)
        {
            _registroService = registroService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegistroModel model)
        {
            var result = _registroService.Register(model.IdEmployee, model.Date, model.RegisterType, model.BusinessLocation);
            return Ok(result); 
        }
    }
}
