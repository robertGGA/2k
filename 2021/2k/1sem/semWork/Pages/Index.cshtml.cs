using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using semWork.Data;
using semWork.Models;

namespace semWork.Pages
{
    public class IndexModel : PageModel
    {
        private readonly FuLearnContext _context;
        public List<User> People { get; set; }
        public IndexModel(FuLearnContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
         
            People = _context.users.ToList();
        }
    }
}
