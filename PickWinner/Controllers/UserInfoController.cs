using Microsoft.AspNetCore.Mvc;
using PickWinner.Models;
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

        [HttpPost("GetLotteryNumbers/{numberOfWinners}")]
        public async Task<IActionResult> GetLotteryNumbers(int numberOfWinners)
        {
            var result = await (userInfo.GetLotteryNumbers(numberOfWinners));
            return Ok(result);
        }


        [HttpPost("GetBonusBall/{numberOfWinners}")]
        public async Task<IActionResult> GetBonusBall(LotteryInfo lotteryList)
        {
            var result = await (userInfo.GetBonusBall(lotteryList));
            return Ok(result);
        }
    }
}

