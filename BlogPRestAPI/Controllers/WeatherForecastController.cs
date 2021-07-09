using BlogPRestAPI.Data;
using BlogPRestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPRestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DataContext _context;
       /* private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        }; */

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContext context)
        {
            _context = context;
            _logger = logger;
        }


        [HttpGet]
        public ActionResult GetValues()
        {
            var values = _context.Posties.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var value = await _context.Posties.FirstOrDefaultAsync(values => values.Id == id);
            return Ok(value);
        }

       
        [HttpPost]
        public string Create(Post data)
        {
            _context.Posties.Add(data);
            _context.SaveChanges();
            return "Basarili kayit.";
        }


    }
}
