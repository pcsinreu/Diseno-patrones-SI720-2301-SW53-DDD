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
    public class AlternativeController : ControllerBase
    {
        // GET: api/Alternative
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Alternative/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Alternative
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Alternative/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Alternative/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
