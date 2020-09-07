using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobileApp.Helper;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {
            return Ok("MobileApi is up and running");
        }

        [HttpGet]
        [Route("AuthorizedUser")]
        [Authorize]
        public IActionResult AuthorizedUser()
        {
            return Ok("MobileApi is up and running");
        }
    }
}
