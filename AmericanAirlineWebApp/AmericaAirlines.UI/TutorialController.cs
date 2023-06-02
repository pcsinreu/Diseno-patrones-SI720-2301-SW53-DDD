using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmericaAirlines.UI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorialController : ControllerBase
    {
        // GET: api/Tutorial
        [HttpGet(Name = "GetTutorials")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "GetTutorial")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
