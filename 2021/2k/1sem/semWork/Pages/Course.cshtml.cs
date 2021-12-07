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
    public class CourseModel : PageModel
    {
        private readonly ICourseRepository _db;

        [BindProperty]
        public string courseName { get; set; }

        [BindProperty]
        public string description { get; set; }

        [BindProperty]
        public string photo { get; set; }

        [BindProperty]
        public int rate { get; set; }

        public string _ID;

        Course course { get; set; }




        public CourseModel(ICourseRepository db)
        {
            _db = db;
        }


        public void OnGet(int id)
        {
            course = _db.GetCourseById(id);
            photo = course.photo;

            description = course.description;

            courseName = course.name;
        }

        public void OnGet() { }
    }
}