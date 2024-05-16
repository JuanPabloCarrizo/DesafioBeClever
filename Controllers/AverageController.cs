using Microsoft.AspNetCore.Mvc;
using System;
using Desafio.Services;

namespace YourProjectName.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AverageController : ControllerBase
    {
        private readonly IAverageService _averageService;

        public AverageController(IAverageService averageService)
        {
            _averageService = averageService;
        }

        [HttpGet("average")]
        public IActionResult GetAverages(DateTime dateFrom, DateTime dateTo)
        {
            var results = _averageService.GetAverages(dateFrom, dateTo);
            return Ok(results);
        }
    }
}
