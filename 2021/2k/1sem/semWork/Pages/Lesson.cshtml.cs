using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services.Interfaces;

namespace semWork.Pages
{
    public class LessonModel : PageModel
    {
        private readonly ILessonRepository _db;

        [BindProperty]
        String src { get; set; }

        [BindProperty]
        IEnumerable<Lessons> lessons { get; set; }

        public LessonModel(ILessonRepository db)
        {
            _db = db;
        }

        public void OnGet()
        {
           //lessons = _db.GetLessonsByCourseId(id);
        }

        public IActionResult OnPost()
        {
            return Redirect("/Lesson");
        }
    }
}