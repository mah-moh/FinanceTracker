using FinanceTracker.DTOs.Requests.User;
using Microsoft.AspNetCore.Mvc;

namespace FinanceTracker.API.Controllers.User
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddUserController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add(AddUserRequest addUserRequest)
        {
            return Ok();
        }
    }
}