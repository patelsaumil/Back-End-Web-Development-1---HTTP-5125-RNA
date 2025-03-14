using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        // <summary>
        // Returns a secret message including the given integer.
        // </summary>
        // <param name="secret">The secret integer value.</param>
        // <returns>A message revealing the secret integer.</returns>
        // <example>
        // POST http://localhost:7029/api/q5/secret_value
        [HttpPost(template: "secret_value")]

        public string secret_value([FromForm] int secret)
        {
            string secret_int = $"Shh.. the secret is {secret}";

            return secret_int;
        }
    }
}
