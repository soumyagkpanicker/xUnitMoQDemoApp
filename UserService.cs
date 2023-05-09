using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xUnitMoqDemoApp.Data;
using xUnitMoqDemoApp.Models;

namespace xUnitMoqDemoApp
{
    [ApiController]
    [Route("[controller]")]
    public class UserService : IUserService
    {
        ApplicationDBContext _appDbContext;
        public UserService(ApplicationDBContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<User> GetUserDetails(int UserId)
        {
            var user = _appDbContext.Users.Where(u => u.UserId == UserId).ToList();
            return user;
        }
        public IEnumerable<User> GetAllUsers()
        {
            var user = _appDbContext.Users;
            return user;
        }
        //public string GeUserId()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
