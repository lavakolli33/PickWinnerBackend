using Microsoft.EntityFrameworkCore;
using PickWinner.Models;
using PickWinner.Models.Interfaces;

namespace PickWinner.Services
{
    public class UserInfoService : IUserInfo
    {
        private readonly AppDBContext context;

        public UserInfoService(AppDBContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<UserInfo>> GetAllUsers()
        {
            return await this.context.userInfos.ToListAsync();
        }

        public async Task<IEnumerable<UserInfo>> GetUsersByIds(int numberOfWinners)
        {
            var randomUsers = await this.context.userInfos.OrderBy(q => Guid.NewGuid()).Take(numberOfWinners).ToListAsync();
            return randomUsers;
        }
    }
}
