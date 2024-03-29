using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularAuthAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using AngularAuthAPI.Context;
using Microsoft.EntityFrameworkCore;

namespace Dashboard_Fullstack.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDBContext _authContext;

        public UserController(AppDBContext appDbContext)
        {
            _authContext = appDbContext;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] User userObj)
        {
            if (userObj == null)
                return BadRequest();

            var user = await _authContext.Users.FirstOrDefaultAsync(x => x.Login == userObj.Login
            && x.Password == userObj.Password);

            if (user == null)
                return NotFound(new {Message = "User not found!"});

            return Ok(new { Message = "Login Success!" });

    }
    }
}
