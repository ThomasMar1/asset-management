using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models.Services
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        IEnumerable<User> GetUsersList();
        User Add(User user);
        User Update(User user);
        User Delete(int id);


    }
}
