using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Desafio.Models;
using Desafio.Services;

namespace Desafio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuscarController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public BuscarController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("search")]
        public IActionResult Search(DateTime dateFrom, DateTime dateTo, string descriptionFilter, string businessLocation)
        {
            var results = _searchService.Search(dateFrom, dateTo, descriptionFilter, businessLocation);
            return Ok(results);
        }
    }
}
