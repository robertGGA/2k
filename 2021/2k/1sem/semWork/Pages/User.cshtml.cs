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
        //private readonly ICourseRepository _dbCourse;
        
        public int id;
        
        private readonly IHostingEnvironment _environment;

        public UserModel (IUserRepository db, IHostingEnvironment environment)
        {
            _db = db;
            //_dbCourse = dbCourse;
            _environment = environment;
        }

        public void OnGet()
        {

            if (Request.Cookies["User"] == null)
            {
                Redirect("/LoginPage");
            }
            else
            {
 
                id = Convert.ToInt32(Request.Cookies["Id"]);

                user = _db.getUserByID(id);
                name = user.login;
                age = user.age;

                //var favCourses = currentUser.favourite_course;
                //if (favCourses != null)
                //{
                //    foreach (var course in favCourses)
                //    {
                //        Courses.Add(_dbCourse.GetCourseById(course.course_id.course_id));
                //    }
                //}
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
                    System.IO.File.Delete(Path.Combine(_environment.ContentRootPath, "photos", user.photo));
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
                string uploadFolder = Path.Combine(_environment.ContentRootPath, "photos");
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
            Response.Cookies.Delete("User");
            return Redirect("/index");
        }


        //public JsonResult OnPostUpload()
        //{
        //    foreach (string file in Request.Files)
        //    {
        //        var upload = Request.Files[file];
        //        if (upload != null)
        //        {
        //            // получаем имя файла
        //            string fileName = System.IO.Path.GetFileName(upload.FileName);
        //            // сохраняем файл в папку Files в проекте
        //            upload.SaveAs(Se
        //              ;
        //        }
        //    }
        //    return Json("файл загружен");
        //}
    }

}