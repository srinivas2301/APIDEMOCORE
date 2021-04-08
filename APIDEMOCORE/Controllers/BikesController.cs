using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDEMOCORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : ControllerBase
    {

        List<string> bikes = initbikes();

        public static List<string> initbikes()
        {
            var bikes = new List<string>() { "yamaha", "pulsar", "honda" };
            return bikes;
        }

        // GET: api/<BikesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return bikes;
        }

        // GET api/<BikesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return bikes[id];
        }

        // POST api/<BikesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BikesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BikesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
