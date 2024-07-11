namespace PickWinner.Models.Interfaces
{
    public interface IUserInfo
    {
        Task<IEnumerable<int>> GetLotteryNumbers(int numbersCount);

        Task<IEnumerable<int>> GetBonusBall(LotteryInfo lotteryList);
    }
}
