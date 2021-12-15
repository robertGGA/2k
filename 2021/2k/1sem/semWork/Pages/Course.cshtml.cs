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
        private readonly ICommentRepository _dbcom;

        [BindProperty]
        public string courseName { get; set; }

        [BindProperty]
        public string description { get; set; }

        [BindProperty]
        public string photo { get; set; }

        [BindProperty]
        public int rate { get; set; }

        [BindProperty]
        public List<Comment> comments { get; set; }

        private int id;

        Course course { get; set; }




        public CourseModel(ICourseRepository db, ICommentRepository dbcom)
        {
            _db = db;
            _dbcom = dbcom;
        }


        public void OnGet(int id)
        {
            this.id = id;
            course = _db.GetCourseById(id);
            photo = course.photo;

            description = course.description;
            courseName = course.name;

            var comments = _dbcom.getCommentsByCourseID(course).ToList();
        }

        public IActionResult OnPost()
        {
            return Redirect("/Course");
        }

    }
}