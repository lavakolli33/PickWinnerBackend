using Microsoft.EntityFrameworkCore;
using PickWinner.Helpers;
using PickWinner.Models;
using PickWinner.Models.Interfaces;
using System.Linq;

namespace PickWinner.Services
{
    public class UserInfoService : IUserInfo
    { 
        public UserInfoService()
        {          
        }

        public Task<List<int>> GetLotteryNumbers(int numbersCount)
        {
            var rnd = new Random();
            // Get an enumerable list of 50 numbers
            var numList = Enumerable.Range(1, 49);
            var randomNumbersList = RandomNumberHelper.GetRandomNumbersList<int>(numList, numbersCount);
            var rno = randomNumbersList.OrderBy(n => n).ToList();
            return Task.FromResult(rno);
        }

        public Task<IEnumerable<int>> GetBonusBall(LotteryInfo lotteryList)
        {
            var rnd = new Random();
            // Get an enumerable list of 50 numbers
            var numList = Enumerable.Range(1, 49).Except(lotteryList.Item);
            var randomNumbersList = RandomNumberHelper.GetRandomNumbersList<int>(numList, 1);
            return Task.FromResult(randomNumbersList);
        }
    }
}
