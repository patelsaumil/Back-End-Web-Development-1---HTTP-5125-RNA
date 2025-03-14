using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        // <summary>
        // Calculates the area of a hexagon given the length of one side.
        // <summary>
        // <returns>The calculated area of the hexagon</returns>
        // <example>
        // GET http://localhost:7029/api/q6/hexagon?side=5
        // Response: 64.95
        [HttpGet(template: "Haxagon")]
        public double hexagon(double side)
        {
            double area = (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
            return area;
        }
    }
}
