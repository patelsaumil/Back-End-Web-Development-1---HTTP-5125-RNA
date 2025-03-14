using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2controller : ControllerBase
    {
        // <summary>
        // Returns a greeting message to the specified name.
        // <returns>A string containing "Hi {name}!"</returns>
        // <example>
        // GET http://localhost:7029/api/q2/greeting?name=Gary
        // Response: Hi Gary!
        

        [HttpGet(template: "greeting")]
        public string greeting(string Name)
        {
            return $"Hi {Name}!";
        }




    }

}
