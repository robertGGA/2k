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
        public static int lessonIndex;

        [BindProperty]
        String src { get; set; }

        [BindProperty]
        IEnumerable<Lessons> lessons { get; set; }

        [BindProperty]
        public int currentPage { get; set; }

        [BindProperty]
        public int nextPage { get; set; }

        [BindProperty]
        public int prevPage { get; set; }

        [BindProperty]
        public int course { get; set; }

        public LessonModel(ILessonRepository db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            course = id;
            lessons = _db.GetLessonsByCourseId(course);
            currentPage = lessons.First().lesson_id;
            lessonIndex = 0;
        }

        public JsonResult OnGetNextPage(int id)
        {
            lessonIndex += 1;
            if(lessonIndex >= _db.GetLessonsByCourseId(id).Count())
            {
                return null;
            } else
            {
                var lessons = _db.GetLessonsByCourseId(id).ToList()[lessonIndex];
                return new JsonResult(lessons);
            }
        }

        public JsonResult OnGetPrevPage(int id)
        {
            lessonIndex -= 1;
            if (lessonIndex < 0)
            {
                return null;
            }
            else
            {
                var lessons = _db.GetLessonsByCourseId(id).ToList()[lessonIndex];
                return new JsonResult(lessons);
            }
        }

        public IActionResult OnPost()
        {
            lessonIndex = 0;
            return Redirect("/Lesson");
        }
    }
}