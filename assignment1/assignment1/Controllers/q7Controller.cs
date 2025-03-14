using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        // <summary>
        // Returns a date adjusted by the specified number of days from January 1, 2000.
        // <summary>
        // <returns>The adjusted date in yyyy-MM-dd format</returns>
        // <example>
        // GET http://localhost:7029/api/q7/timemachine?day=1000
        // Response: 2002-09-27
        [HttpGet(template: "timemachine")]
        public string timemachine(int day)
        {
            DateTime adjusting_date = new DateTime(2000, 1, 1).AddDays(day);
            return (adjusting_date.ToString("yyyy-MM-dd"));
        }
    }
}
