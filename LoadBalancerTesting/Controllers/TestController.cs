using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoadBalancerTesting.Controllers
{
    [ApiController]
    [Route("")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Console.WriteLine("Hello World");
            return Ok("Hello World");
        }
    }
}
