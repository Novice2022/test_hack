using Hakaton.DataAccess;
using Hakaton.Models;
using Hakaton.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hakaton.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : Controller
    {
        private readonly HakatonDbContext _dbContext;
        private readonly ILogger<AuthorizationController> _logger;

        public UserController(HakatonDbContext dbContext, ILogger<AuthorizationController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet("getallusers")]
        [Authorize]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _dbContext.Users.ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound("No users found.");
            }

            return Ok(users);
        }
    }
}
