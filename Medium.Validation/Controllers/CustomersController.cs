using Microsoft.AspNetCore.Mvc;

namespace Medium.Validation.Controllers
{
    /// <summary>
    /// Customers resource
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        /// <summary>
        /// Create Customer
        /// </summary>
        [HttpPost()]
        public ActionResult Post([FromBody]CustomerPost customerPost)
        {
            // Criação de Customer em service.

            return Created(string.Empty, 123);
        }
    }
}
