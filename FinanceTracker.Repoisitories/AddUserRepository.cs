using FinanceTracker.Aggregator.User;

namespace FinanceTracker.Repoisitories
{
    public class AddUserRepository : IAddUserRepository
    {
        public Task<bool> InsertAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}