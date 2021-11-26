using System;
using System.Collections;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
    }
}
