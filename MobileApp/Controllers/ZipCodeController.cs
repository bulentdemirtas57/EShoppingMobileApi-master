using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobileApp.Core;
using MobileApp.Data.Repositories;
using MobileApp.Models;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZipCodeController : ControllerBase
    {
        private readonly IZipCodeRepository _zipCodeRepository;
        private readonly IConfiguration _configuration;

        public ZipCodeController(IZipCodeRepository zipCodeRepository, IConfiguration configuration)
        {
            _zipCodeRepository = zipCodeRepository;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Check")]
        [AllowAnonymous]
        public IActionResult Check([FromForm] ZipCodeModel model)
        {
            var zipCode = _zipCodeRepository.Check(model.ZipCode);

            if (zipCode)
                return Ok("Bu posta kodu ile işlem yapılabilir.");

            throw new ApiException("Bu Posta Kodu ile hizmet veremiyoruz.");
        }
    }
}
