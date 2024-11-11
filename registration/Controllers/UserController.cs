using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using registration.Dto;
using registration.Repository;

namespace registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost]
        public IActionResult SignUp ([FromBody]signupDto signupDto)
        {
            _userRepo.SignUp(signupDto);
            return Ok();
        }
        [HttpGet]
        public IActionResult Login ([FromQuery]loginDto loginDto)
        {
            var result = _userRepo.Login(loginDto);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);

        }
    }
}
