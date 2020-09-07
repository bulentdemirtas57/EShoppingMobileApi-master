using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MobileApp.Core;
using MobileApp.Data.Repositories;
using MobileApp.Models;
using System;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewServiceAreaController : ControllerBase
    {
        private readonly INewServiceAreaRepository _newServiceAreaRepository;
        private readonly IConfiguration _configuration;

        public NewServiceAreaController(INewServiceAreaRepository newServiceAreaRepository, IConfiguration configuration)
        {
            _newServiceAreaRepository = newServiceAreaRepository;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("NewServiceAreaRecommendation")]
        [AllowAnonymous]
        public IActionResult NewServiceAreaRecommendation([FromForm] NewServiceAreaModel model)
        {

            if (_newServiceAreaRepository.Exists(model.SPostaCodeName))
            {
                throw new ApiException("Bu Posta Kodu sistemde tanımlıdır.");
            }

            _newServiceAreaRepository.Add(new Data.Models.TblNewServiceArea
            {
                SPostaCodeName = model.SPostaCodeName,
                SMobileNumber = model.SMobileNumber,
                SEmailAddress = model.SEmailAddress,
                IPostaCodeId = 0,
                DCreateDate = DateTime.Now,
                DCreateDt = DateTime.Now,
                BEnable = 1,
                BArchive = 0,
                SNewServiceAreaStatus = "Aktive"
            });

            return Ok("Talebiniz alınmıştır.");
        }
    }
}
