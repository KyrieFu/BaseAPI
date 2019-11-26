using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseAPI.Module;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BaseAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly LoginModule _loginModule;

        public UserController(ILogger<UserController> logger, LoginModule loginModule)
        {
            _logger = logger;
            _loginModule = loginModule;
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return Ok(_loginModule.GetName());
        }
    }
}