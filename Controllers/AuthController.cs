using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "miguel" && password == "123456")
            {
                var token = TokenServices.GenerateToken(new Model.Employee());
                return Ok(token);
            }

            return BadRequest("username of password invalid");
        }
    }
}
