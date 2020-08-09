using micro_lotto.Data.Contracts;
using micro_lotto.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace micro_lotto.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserData()
        {
            try
            {
            return await _userService.GetUserById();
            }
            catch (System.Exception)
            {
                return StatusCode(500, "Unable to get user info");
            }
        }
    }
}