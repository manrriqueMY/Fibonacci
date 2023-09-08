using Fibonacci.Models;
using Fibonacci.Service;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FibonacciController : ControllerBase
    {
        public FibonacciService Service { get; set; }
        public FibonacciController(FibonacciService service) {
            Service = service;
        }

        [HttpGet("[action]/{position}")]
        public Response FindPosition(int position)
        {
            return Service.FindPosition(position);
        }
    }
}