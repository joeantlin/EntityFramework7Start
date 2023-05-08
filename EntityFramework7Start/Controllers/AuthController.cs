using System;
using EntityFrameWork7Start.DTOs.User;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork7Start.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
	{
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
		{

			_authRepo = authRepo;
		}

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegisterDTO newUser)
        {
            var response = await _authRepo.Register(
                new User { Username = newUser.Username },
                newUser.Password
            );
            if (!response.Success)
            {
                return BadRequest(response);

            }
            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<int>>> Login(UserLoginDTO user)
        {
            var response = await _authRepo.Login(user.Username, user.Password);
            if (!response.Success)
            {
                return BadRequest(response);

            }
            return Ok(response);
        }
    }
}

