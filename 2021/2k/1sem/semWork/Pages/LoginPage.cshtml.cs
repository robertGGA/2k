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
            if (Request.Cookies["User"] == null)
            {
                return;
            }
            Redirect("/user");
        }

        public IActionResult OnPostLoginUser()
        {
            if (_db.getUserByName(Login) == null)
            {
                return Redirect("/LoginPage");
            }
            else
            {
                user = _db.getUserByName(Login);
            }
           
            if (BC.Verify(Password, user.password))
            {
                var cookieOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddMinutes(10)
                };
                Response.Cookies.Append("User", user.login, cookieOptions);
                Response.Cookies.Append("Id", user.user_id.ToString(), cookieOptions);
                HttpContext.Session.Set("current_user", BitConverter.GetBytes(user.user_id));
                return Redirect("/user");
            } else
            {
                return Redirect("/LoginPage");
            }

            //Тимур, у меня к тебе важный вопрос. Как ты переходил по нужнему айтему в списке?
            
        }
    }
}