using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using semWork.Data;
using semWork.Models;

namespace semWork.Services
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();

        public User Add(User newUser);

        public User getUserByID(int id);

        public User getUserByName(String name);

        public bool isUserExists(String name);

        public Task UpdateUserPhoto(User user);
    }
}
