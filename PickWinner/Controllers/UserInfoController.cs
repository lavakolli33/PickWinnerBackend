using Microsoft.AspNetCore.Mvc;
using PickWinner.Models.Interfaces;

namespace PickWinner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserInfoController : Controller
    {
        private readonly IUserInfo userInfo;

        public UserInfoController(IUserInfo userInfo)
        {
            this.userInfo = userInfo;
        }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await (userInfo.GetAllUsers());
            return Ok(result);
        }

        [HttpPost("GetUsersByIds/{numberOfWinners}")]
        public async Task<IActionResult> GetUsersByIds(int numberOfWinners)
        {
            var result = await (userInfo.GetUsersByIds(numberOfWinners));
            return Ok(result);
        }
    }
}

