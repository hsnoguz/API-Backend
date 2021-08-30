using Bussines.Abstract;
using Core.Extensions;
using Microsoft.AspNetCore.Mvc;
using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemelService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;

        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.IsValid)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.IsValid)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }



      [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.IsValid)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);

            if (result.IsValid)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("refreshToken")]
        public ActionResult RefreshToken(string refreshToken)
        {
            var claim = HttpContext.User.ClaimNameIdentifier();
            if (claim.Count > 0)
            {
                int userId = Convert.ToInt32(claim[0].ToString());
                bool lastToken = _authService.getRefreshTokenControl(userId, refreshToken);
                if (lastToken)
                {

                    var result = _authService.setNewRefreshToken(userId);
                    if (result.IsValid)
                    {
                        return Ok(result.Data);
                    }
                    else
                    {
                        return BadRequest(result.Message);
                    }
                }
                else
                {
                    return BadRequest("Token Hatalı!");
                }
           
            }
            else
            {
                return BadRequest("Token Hatalı!");
            }

        }
    }
}
