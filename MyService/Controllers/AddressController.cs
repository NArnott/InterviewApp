using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyService.Stores;

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

        //TODO: Implement APIs for the following AddressStore Methods:
        //_store.GetAddressesAsync
        //_store.GetAddressByIdAsync 
        //_store.AddAddressAsync 
    }
}
