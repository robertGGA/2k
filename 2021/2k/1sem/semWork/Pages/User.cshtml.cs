using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services;
using semWork.Services.Interfaces;

namespace semWork.Pages.Users
{
    public class UserModel : PageModel
    {
        [BindProperty]
        public string name { get; set; }
        [BindProperty]
        public int age { get; set; }

        public List<Course> Courses;
        private readonly IUserRepository _db;
        private readonly ICourseRepository _dbCourse;
        public User currentUser;

        public UserModel (IUserRepository db, ICourseRepository dbCourse)
        {
            _db = db;
            _dbCourse = dbCourse;
        }

        public void OnGet()
        {

            if (Request.Cookies["User"] == null)
            {
                Redirect("/LoginPage");
            }

            name = Request.Cookies["User"];
            currentUser = _db.getUserByName(name);

            var favCourses = currentUser.favourite_course;
            if (favCourses != null)
            {
                foreach (var course in favCourses)
                {
                    Courses.Add(_dbCourse.GetCourseById(course.course_id.course_id));
                }
            }


        }

        public IActionResult OnPostLogOut()
        {
            Response.Cookies.Delete("User");
            return Redirect("/index");
        }
    }

}