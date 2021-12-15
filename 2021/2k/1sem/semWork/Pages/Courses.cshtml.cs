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
    public class CoursesModel : PageModel
    {
        public IEnumerable<Course> courses;

        private readonly ICourseRepository _db;

        public CoursesModel(ICourseRepository db) => _db = db;

        public void OnGet()
        {
            if (HttpContext.Request.Cookies["Id"] == null)
            {
                Redirect("/LoginPage");
            }
            courses = _db.GetAllCourses();

        }

        
    }
}