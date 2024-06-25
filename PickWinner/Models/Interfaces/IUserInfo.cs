namespace PickWinner.Models.Interfaces
{
    public interface IUserInfo
    {
        Task<IEnumerable<UserInfo>> GetUsersByIds(int numberOfWinners);

        Task<IEnumerable<UserInfo>> GetAllUsers();
    }
}
