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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserStore _store;

        public UserController(UserStore store, ILogger<UserController> logger)
        {
            _logger = logger;
            _store = store;
        }

        //TODO: Implement APIs for the following UserStore Methods:
        //_store.GetUsersAsync
        //_store.GetUserByIdAsync (Must return 404-Not Found if that id doesn't exist.
        //_store.AddUserAsync 
    }
}
