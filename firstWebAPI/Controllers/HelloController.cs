using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public HelloController()
        {

        }

        [HttpGet]
        public IActionResult GetResult()
        {
            return Ok("Hello Prashanth");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            return Ok(payload);
        }
    }
}
