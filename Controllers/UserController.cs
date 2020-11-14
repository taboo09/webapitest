using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapitest.Models;

namespace webapitest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            var user = new User() 
            {
                Id = Guid.NewGuid(),
                Name = "John Smith",
                Address = null,
                Contact = null
            };

            return Ok(user);
        }
    }
}