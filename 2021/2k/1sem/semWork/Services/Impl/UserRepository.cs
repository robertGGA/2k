using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;

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

        public User getUserByID(int id)
        {
            return context.users.Find(id);
        }

        public User getUserByName(string name)
        {
            throw new NotImplementedException();
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
