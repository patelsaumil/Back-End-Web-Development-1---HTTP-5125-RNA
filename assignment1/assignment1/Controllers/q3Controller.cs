using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        // <summary>
        // Returns the cube of the specified integer
        // <returns>The cube of the input integer</returns>
        // <example>
        // GET http://localhost:xx/api/q3/cube/4
        // Response: 64
        
        [HttpGet]
        [Route(template: "/api/q3/{cube_int}")]
        public int Cube(int cube_int)
        {

            int cube_value = cube_int * cube_int * cube_int;
            return cube_value;
        }
    }
}
