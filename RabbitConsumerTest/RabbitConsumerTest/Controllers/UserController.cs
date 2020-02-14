using Microsoft.AspNetCore.Mvc;
using Model.DTO.User;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitConsumerTest.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserRequestModel user)
        {
            await _userService.Add(user);
            return NoContent();
        }

        [HttpGet, Route("{exchangeName}")]
        public async Task<IActionResult> CreateRabbitConsumerConnection ([FromRoute] string exchangeName)
        {
            await _userService.ConsumeExchangeEntity(exchangeName);
            return NoContent();
        }
    }
}
