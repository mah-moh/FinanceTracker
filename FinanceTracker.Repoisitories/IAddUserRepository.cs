using FinanceTracker.Aggregator.User;

namespace FinanceTracker.Repoisitories
{
    public interface IAddUserRepository
    {
        Task<bool> InsertAsync(User user);
    }
}