using System;
using System.Collections.Generic;
using System.Linq;
using BC = BCrypt.Net.BCrypt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services;
using Microsoft.AspNetCore.Http;

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
            if(Request.Cookies["User"] != null)
            {
                Redirect("/user");
            }
        }

        public IActionResult OnPostLoginUser()
        {
            var userLocal = _db.getUserByName(Login);
           
            if (BC.Verify(Password, userLocal.password))
            {
                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(5)
                };
                Response.Cookies.Append("User", userLocal.login, cookieOptions);
                return Redirect("/user");
            } else
            {
                Console.WriteLine("Failed");
                return Redirect("/LoginPage");
            }
            
            
        }
    }
}