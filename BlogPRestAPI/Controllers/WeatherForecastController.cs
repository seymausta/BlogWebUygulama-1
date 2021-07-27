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
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        private DataContext _context;
     

        public WeatherForecastController( DataContext context)
        {
            _context = context;
          
        }

        
        [Route("allposts")]
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

        [Route("create")]
        [HttpPost]
        public string Create(Post data)
        {
            _context.Posties.Add(data);
            _context.SaveChanges();
            return "Basarili kayit.";
        }

        [Route("update")]
        [HttpPut]
        public ActionResult Put(PostUpdateDto data)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (_context)
            {
                var existingPost = _context.Posties.Where(s => s.Id == data.Id)
                                                        .FirstOrDefault<Post>();

                if (existingPost != null)
                {
                    existingPost.Title = data.Title;
                    existingPost.Content = data.Content;

                    _context.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }


    }
}