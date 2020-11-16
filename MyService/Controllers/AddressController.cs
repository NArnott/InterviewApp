using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyService.Stores;
using System.Threading.Tasks;

namespace MyService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly AddressStore _store;

        public AddressController(AddressStore store, ILogger<AddressController> logger)
        {
            _logger = logger;
            _store = store;
        }

        [HttpGet]
        public Task<Address[]> GetAddressesAsync()
        {
            return _store.GetAddressesAsync();
        }

        [HttpGet("{addressId}")]
        public async Task<ActionResult<Address>> GetAddressByIdAsync(int addressId)
        {
            var address = await _store.GetAddressByIdAsync(addressId);

            if (address == null)
                return NotFound();

            return address;
        }

        [HttpPost]
        public Task AddAddressAsync(Address address)
        {
            return _store.AddAddressAsync(address);
        }
    }
}
