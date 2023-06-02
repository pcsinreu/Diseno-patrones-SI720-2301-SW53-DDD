using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmaericanAirline.API.Controllers.Passagers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        // GET: api/Passenger
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Passenger/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            // Seguridad 
            // Recojo de informar devolucion
            
            return "value";
        }

        // POST: api/Passenger
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Passenger/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Passenger/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
