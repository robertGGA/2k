using System;
using BC = BCrypt.Net.BCrypt;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services;

namespace semWork.Pages
{
    public class RegPageModel : PageModel
    {

        [BindProperty]
        public new User User { get; set; }
        [BindProperty]
        public string Login { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string ConfPassword { get; set; }
        [BindProperty]
        public int date { get; set; }

        private readonly IUserRepository _db;

        public User Model { get; set; }

        public RegPageModel(IUserRepository db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostCreateUser()
        {

                    var pass = BC.HashPassword(Password);

                    var confPass = BC.HashPassword(ConfPassword);

                    Console.WriteLine(pass + " " + confPass);
                    User user = new User();
                    user.login = Login;
                    user.password = pass;
                    user.age = date;
                    _db.Add(user);
                    return Redirect("/LoginPage");
     
        }
    }
    
}