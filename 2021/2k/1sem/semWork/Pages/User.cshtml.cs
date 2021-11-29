using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semWork.Pages.Users
{
    public class UserModel : PageModel
    {
        [BindProperty]
        public string name { get; set; }
        public void OnGet()
        {
            name = Request.Cookies["User"];
        }
    }
}