using FinanceTracker.DTOs.Requests.User;

namespace FinanceTracker.Handlers
{
    public interface IAddUserHandler
    {
        Task<bool> AddUserAsync(AddUserRequest addUserRequest);
    }
}