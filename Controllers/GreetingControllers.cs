using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AHello.Controllers
{
    [ApiController]
    [Route("/scaryhello")]
    public class ScaryController : ControllerBase
    {

        private readonly ILogger<ScaryController> _logger;

        public ScaryController(ILogger<ScaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Greeting Get()
        {
            var greeting = new Greeting();
            greeting.greeting = "Hello Scary World!";
            return greeting;
        }
    }

    [ApiController]
    [Route("/safehello")]
    public class SafeController : ControllerBase
    {

        private readonly ILogger<SafeController> _logger;

        public SafeController(ILogger<SafeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Greeting Get()
        {
            var greeting = new Greeting();
            greeting.greeting = "Hello Safe World!";
            return greeting;
        }
    }


}
