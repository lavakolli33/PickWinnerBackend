namespace PickWinner.Models.Interfaces
{
    public interface IUserInfo
    {
        Task<List<int>> GetLotteryNumbers(int numbersCount);

        Task<IEnumerable<int>> GetBonusBall(LotteryInfo lotteryList);
    }
}
