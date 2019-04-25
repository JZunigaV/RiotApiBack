using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RiotBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionsController : ControllerBase
    {

     
        // GET: api/Champions
        [HttpGet]
        public string Get()
        {
            return "Jax";
        }

        // GET: api/Champions/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        // POST: api/Champions
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT: api/Champions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
