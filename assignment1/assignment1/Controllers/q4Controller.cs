using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        // <summary>
        // Returns the start of a knock-knock
        // <summary>
        // <returns>A string containing "Who’s there?"</returns>
        // <example>
        // POST http://localhost:7029/api/q4/knockknock
        // Response: Who’s there?
        [HttpPost("knockknock")]
        public string knockknock()
        {
            return ("Who's there?");
        }
    }
}
