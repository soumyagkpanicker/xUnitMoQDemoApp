using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle;
using xUnitMoqDemoApp.Models;

namespace xUnitMoqDemoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userService.GetAllUsers();
        }
        [HttpGet("GetUsersById/{id}")]
        public IEnumerable<User> GetUsersById(int id)
        {
            return _userService.GetUserDetails(id);
        }
    }
}
