using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace semWork.Services.Impl
{
    public class UserRepository: IUserRepository
    {
        private readonly FuLearnContext context;

        public UserRepository(FuLearnContext context)
        {
            this.context = context;
        }

        public User Add(User newUser)
        {
            context.Add(newUser);
            context.SaveChanges();
            return newUser;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.users;
        }

        public async Task UpdateUserPhoto(User user)
        {
            try
            {
                context.Update(user);
                context.SaveChanges();
            } catch (DbUpdateConcurrencyException)
            {
                throw;
            }

        }

        public User getUserByID(int id)
        {
            return context.users.Find(id);
        }

        public User getUserByName(string name)
        {
            var users = (from user in context.users
                         where user.login == name
                         select user).ToList();
            return users.FirstOrDefault();
        }

     

        public bool isUserExists(string name)
        {
            if(context.users.Find(name) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
