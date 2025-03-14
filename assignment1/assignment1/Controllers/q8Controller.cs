using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        // <summary>
        // Returns a checkout summary for an order of SquashFellows
        // <returns>A string summarizing the order, subtotal, tax, and total cost.</returns>
        // <example>
        // POST http://localhost:7029/api/q8/squashfellows
        // Request Body: Small=1&Large=1
        // Response: "1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58"

        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double smallprice = 25.50;
            double largeprice = 40.50;
            double HST = 0.13;

            double smalltotal = small * smallprice;
            double largetotal = large * largeprice;
            double subtotal = smalltotal + largetotal;
            double tax = Math.Round(subtotal * HST, 2);
            double total = Math.Round(subtotal + tax, 2);

            string result = $"{small} Small @ {smallprice:F2} = ${smallprice:F2}; " + $"{large} Large @ {largeprice:F2} = ${largeprice:F2}; " + $"Subtotal = ${subtotal:F2}; " + $"Tax = ${tax:F2}; " + $"total = ${total:F2}";
            return result;


        }
    }
}