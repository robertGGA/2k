using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
        [BindProperty]
        public IFormFile Photo { get; set;}

        
        
        public User user { get; set; }

    
        public List<Course> Courses;
        private readonly IUserRepository _db;
        private readonly ICourseRepository _dbCourse;
        private readonly IFavouriteCourses _fvCourse;
        
        public int id;
        
        private readonly IHostingEnvironment _environment;

        public UserModel (IUserRepository db, ICourseRepository dbCourse, IFavouriteCourses fvCourse,  IHostingEnvironment environment)
        {
            _db = db;
            _dbCourse = dbCourse;
            _environment = environment;
            _fvCourse = fvCourse;
        }

        public void OnGet()
        {
            Console.Write(Request.Cookies["Id"]);
            if (Request.Cookies["Id"] == null)
            {
                RedirectToPage("/LoginPage");
            }
            else
            {
                Courses = new List<Course>();
                id = Convert.ToInt32(Request.Cookies["Id"]);

                user = _db.getUserByID(id);
                name = user.login;
                age = user.age;

                var favCourses = _fvCourse.GetCoursesListByUserId(user.user_id);
                
                if (favCourses != null)
                {
                    foreach (var course in favCourses)
                    {
                        Courses.Add(_dbCourse.GetCourseById(course.course.course_id));
                    }
                }
            }


        }

     

        public IActionResult OnPost(User user)
        {
           user = _db.getUserByID(Convert.ToInt32(Request.Cookies["Id"]));
            Console.WriteLine(Path.Combine("photos", user.photo));

           if(Photo != null)
            {

                if(user.photo != null)
                {
                    string path = _environment.WebRootPath + user.photo;
                    System.IO.File.Delete(path);
                }
                user.photo = "/photos/" + uploadFile();
                
            }
        
            _db.UpdateUserPhoto(user);
            return Redirect("/user");
        }

        private string uploadFile()
        {
            string fileName = null;

            if (Photo != null)
            {
                string uploadFolder = Path.Combine(_environment.WebRootPath, "photos");
                Console.WriteLine(uploadFolder + " <<<<----");
                fileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                Console.WriteLine(fileName);
                string filePath = Path.Combine(uploadFolder, fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
            }
            return fileName;
        }


        public IActionResult OnPostLogOut()
        {
            foreach (var cookie in HttpContext.Request.Cookies)
            {
                Response.Cookies.Delete(cookie.Key);
            }
            return Redirect("/index");
        }
    }

}