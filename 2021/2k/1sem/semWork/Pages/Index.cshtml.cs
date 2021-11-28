using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using semWork.Data;
using semWork.Models;
using semWork.Services;

namespace semWork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserRepository _db;
        public IndexModel(IUserRepository db)
        {
            _db = db;
        }

        public IEnumerable<User> Users { get; set; }
        public User user;

        public void OnGet()
        {

            user = _db.getUserByID(1);
        }
    }
}
