using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semWork.Models;
using semWork.Services;
using semWork.Services.Interfaces;

namespace semWork.Pages
{
    public class CourseModel : PageModel
    {
        private readonly ICourseRepository _db;
        private readonly ICommentRepository _dbcom;
        private readonly IUserRepository _userdb;

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

        [BindProperty]
        public string comment { get; set; }

        [BindProperty]
        public int CourseId { get; set; }

        [BindProperty]
        public User user { get; set; }

        [BindProperty]
        public Course course { get; set; }




        public CourseModel(ICourseRepository db, ICommentRepository dbcom, IUserRepository userdb)
        {
            _db = db;
            _dbcom = dbcom;
            _userdb = userdb;
        }


        public void OnGet(int id)
        {
            if(HttpContext.Request.Cookies["Id"] == null)
            {
                Redirect("/index");
            }

            CourseId = id;
            course = _db.GetCourseById(id);
            photo = course.photo;
            description = course.description;
            courseName = course.name;
            user = _userdb.getUserByID(int.Parse(HttpContext.Request.Cookies["Id"]));
            comments = _dbcom.getCommentsByCourseID(course).ToList();
        }

        public IActionResult OnPostCreateComment(int user, int courseId)
        {
            User currentUser = _userdb.getUserByID(user);
            this.user = currentUser;
            Course currentCourse = _db.GetCourseById(courseId);
            this.course = course;
            Comment localComment = new Comment(currentUser, currentCourse, comment);

            _dbcom.addComment(localComment);
            comments.Add(localComment);
            return Redirect("/Course/" + courseId);

        }

        public IActionResult OnPost()
        {

            return Redirect("/Course");
        }

    }
}