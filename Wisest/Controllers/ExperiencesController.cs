using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Wisest.Models;
using System.Net;
using System.Text.Json;

namespace Wisest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperiencesController : ControllerBase
    {
        // GET: api/Experiences
        [HttpGet]
        public async Task<IEnumerable<Experience>> Get()
        {
            var exp1 = new Experience(1, "asd", "asd");
            var exp2 = new Experience(2, "asd", "asd");
            var list = new List<Experience>();
            list.Add(exp1);
            list.Add(exp2);
            return list;
        }

        // GET: api/Experiences/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Experiences
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Experiences/5
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
