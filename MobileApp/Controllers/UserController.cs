using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MobileApp.Core;
using MobileApp.Data.Repositories;
using MobileApp.Helper;
using MobileApp.Models;
using MobileApp.Token;

namespace MobileApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserController> _logger;
        private readonly IConfiguration _configuration;

        public UserController(IUserRepository userRepository, ILogger<UserController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _userRepository = userRepository;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public IActionResult Register([FromForm] UserRegisterModel model)
        {
            if (string.IsNullOrWhiteSpace(model.FirstName))
                throw new ApiException("İsim alanı zorunludur.");

            if (string.IsNullOrWhiteSpace(model.Surname))
                throw new ApiException("Soyisim alanı zorunludur.");

            if (string.IsNullOrWhiteSpace(model.Email))
                throw new ApiException("E-mail alanı zorunludur.");

            if (string.IsNullOrWhiteSpace(model.Password))
                throw new ApiException("Şifre alanı zorunludur.");

            if (string.IsNullOrWhiteSpace(model.PhoneNumber))
                throw new ApiException("Telefon alanı zorunludur.");

            var user = _userRepository.Register(model.FirstName, model.Surname, model.PhoneNumber, model.Email, model.Password);

            return Ok(user);
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public IActionResult Login([FromForm] LoginModel model)
        {
            if (_userRepository.CheckEmail(model.Username))
            {
                throw new ApiException("Bu mail adresi ile tanımlı bir kullanıcı bulunmamaktadır.");
            }

            var user = _userRepository.Login(model.Username, model.Password);

            if (user == null)
                throw new ApiException("Kullanıcı adı veya şifre yanlış.");

            TokenHandler tokenHandler = new TokenHandler(_configuration);

            var token = tokenHandler.CreateAccessToken(user);

            _userRepository.UpdateUserRefreshToken(user.IUserId, token.RefreshToken, DateTime.Now.AddDays(30));

            return Ok(token);
        }

        [HttpPost]
        [Route("RefreshTokenLogin")]
        [AllowAnonymous]
        public IActionResult RefreshTokenLogin([FromForm] string refreshToken)
        {
            var user = _userRepository.GetUserByRefreshToken(refreshToken);

            if (user != null && user?.DRefreshTokenEndDate > DateTime.Now)
            {
                TokenHandler tokenHandler = new TokenHandler(_configuration);
                var token = tokenHandler.CreateAccessToken(user);

                _userRepository.UpdateUserRefreshToken(user.IUserId, token.RefreshToken, DateTime.Now.AddDays(30));

                return Ok(token);
            }

            throw new ApiException("Kullanıcı bulunamadı.");
        }
    }
}
