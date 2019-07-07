using AssetManagement.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Models
{
    public class UserRepository : IUserRepository
    {
        //private List<User> _userList;
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;

            //_userList = new List<User>()
            //{
            //    new User() { Id= 1, Name = "Mary Potts", Email= "marypotts@email.com", Address = "123 Wakefield Street, Auckland"},
            //    new User() { Id = 2, Name = "Daniel Yang", Email = "dyang98765@email.com", Address = "98 Avondale Road, Auckland" },
            //    new User() { Id = 3, Name = "James Smith-Bell", Email = "jsbell@email.com", Address = "20 Hollow Place, Auckland" },
            //    new User() { Id = 4, Name = "Jane Richards", Email = "janerich@email.com", Address = "455 Great North Road, Auckland" }
            //};
        }
        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = context.Users.Find(id);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }

        public User GetUser(int Id)
        {
            return context.Users.Find(Id);
        }

        public IEnumerable<User> GetUsersList()
        {
            return context.Users;
        }

        public User Update(User userChanges)
        {
            var user = context.Users.Attach(userChanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return userChanges;
        }
        //public User Add(User user)
        //{
        //    throw new NotImplementedException();
        //}

        //public User Delete(int id)
        //{
        //    User user = _userList.FirstOrDefault(u => u.Id == id);
        //    if (user != null)
        //    {
        //        _userList.Remove(user);
        //    }
        //    return user;
        //}

        //public User GetUser(int Id)
        //{
        //    return _userList.FirstOrDefault(u => u.Id == Id);
        //}


        //public IEnumerable<User> GetUsersList()
        //{
        //    return _userList;
        //}

        //public User Update(User user)
        //{
        //    User selectedUser = _userList.FirstOrDefault(u => u.Id == user.Id);
        //    if (user != null)
        //    {
        //        selectedUser.Name = user.Name;
        //        selectedUser.Email = user.Email;
        //        selectedUser.Address = user.Address;
        //     }
        //    return selectedUser;
        //}
    }
}
