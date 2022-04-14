using Microsoft.AspNetCore.Mvc;
using PracticeApplication.Interface;

namespace PracticeApplication.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private ICalculateService _calculateService;
        

        public HelloController(ICalculateService calculateService)
        {
            _calculateService = calculateService;
        }

        [HttpGet]
        public IActionResult SayHello([FromQuery]uint id)
        {
            System.Console.WriteLine(id);
            var str = "Hello, my friend!";
            return Ok("str");
        }

        [HttpPost("sum")]
        public IActionResult SumNumbers([FromBody]Person parameter)
        {
            var sum = _calculateService.SumNumbers(parameter.Numbers);
            return Ok(sum);
        }

        public class Person
        {
            public string Name {get; set;}
            public int[] Numbers {get; set;}
        }
    }
}