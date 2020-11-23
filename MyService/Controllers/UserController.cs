using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyService.Stores;
using System.Threading.Tasks;

namespace MyService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserStore _store;

        public UserController(UserStore store, ILogger<UserController> logger)
        {
            _logger = logger;
            _store = store;
        }

        [HttpGet]
        public Task<User[]> GetUsersAsync()
        {
            return _store.GetUsersAsync();
        }

        [HttpGet("{addressId}")]
        public async Task<ActionResult<User>> GetAddressByIdAsync(int userId)
        {
            var address = await _store.GetUserByIdAsync(userId);

            if (address == null)
                return NotFound();

            return address;
        }

        [HttpPost]
        public Task AddAddressAsync(User user)
        {
            return _store.AddUserAsync(user);
        }
    }
}
