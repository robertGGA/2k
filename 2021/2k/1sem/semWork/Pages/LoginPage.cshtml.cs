using System;
using System.Collections.Generic;
using System.Linq;
using BC = BCrypt.Net.BCrypt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services;

namespace semWork.Pages
{
    public class LoginPageModel : PageModel
    {

        [BindProperty]
        public string Login { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public User user { get; set; }

        private readonly IUserRepository _db;

        public LoginPageModel(IUserRepository db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostLoginUser()
        {
            //user = _db.getUserByName(Login);
            if (BC.Verify(Password, user.password))
            {
                Console.WriteLine("CONGRATZ");
                return Redirect("/index");
            } else
            {
                Console.WriteLine("Failed");
                return Redirect("/LoginPage");
            }
            
            
        }
    }
}