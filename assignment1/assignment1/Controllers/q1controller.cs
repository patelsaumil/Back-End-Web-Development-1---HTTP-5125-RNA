using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class q1controller : ControllerBase
    {
        // <summary>
        // Returns a welcome message.
        // <summary>
        // <returns>A string containing "Welcome to 5125!"</returns>
        // <example>
        // GET http://localhost:7029/api/q1/welcome
        // Response: Welcome to http 5125
         
        [HttpGet]
        public string Get()
        {
            return "welcome to http 5125";
        }
    }
}
