using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        // GET: api/<PruebaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PruebaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PruebaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            return new string[] { "value1", "value2" };
        }

        // PUT api/<PruebaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            return null;
        }

        // DELETE api/<PruebaController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return true;
        }
    }
}
