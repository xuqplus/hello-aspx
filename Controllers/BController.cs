using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hello_aspx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BController : Controller
    {
        // GET: api/<BController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "世界." };
        }

        // GET api/<BController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Hello " + id;
        }

        // POST api/<BController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // /api/b/ha
        [Route("ha")]
        public string Ha()
        {
            return "haha";
        }

        // /api/b/hi
        [Route("hi")]
        public IActionResult Hi()
        {
            return View();
        }

        // /api/b/hi2
        [Route("hi2")]
        public IActionResult Hi2()
        {
            return PartialView();
        }


    }
}
