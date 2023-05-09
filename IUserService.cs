using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xUnitMoqDemoApp.Models;

namespace xUnitMoqDemoApp
{
    public interface IUserService
    {
        //    string GeUserId();
        IEnumerable<User> GetUserDetails(int UserId);
        IEnumerable<User> GetAllUsers();
    }
}
