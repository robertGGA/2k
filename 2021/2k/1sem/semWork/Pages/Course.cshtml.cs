using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using semWork.dto;
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
        private readonly IFavouriteCourses _favdb;
        private readonly IRateRepository _ratedb;

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

        [BindProperty]
        public bool isFavourite { get; set; }

        [BindProperty]
        public float avgRate { get; set; }




        public CourseModel(ICourseRepository db, ICommentRepository dbcom, IUserRepository userdb, IFavouriteCourses favdb, IRateRepository ratedb)
        {
            _db = db;
            _dbcom = dbcom;
            _userdb = userdb;
            _favdb = favdb;
            _ratedb = ratedb;
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
            List<Rate> rating = _ratedb.GetRatesByCourse(course).ToList();
            if(rating.Count == 0)
            {
                avgRate = 0;
            } else
            {
                avgRate = rating.Sum(item => item.rate) / rating.Count();
            }
            
        }

        public ActionResult OnPostAddFavCourse()
        {
            int course = 0;
            int user = 0;
            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();
                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<FavCoursesWrapper>(requestBody);
                        if (obj != null)
                        {
                            course = int.Parse(obj.CourseId);
                            user = int.Parse(obj.UserId);
                        }
                    }
                }
                
                if (_favdb.IsExists(course, user)) 
                {
                    FavouriteCourses favCourse = _favdb.GetCourseByUserIdAndCourseId(course, user);
                    _favdb.DeleteFavouriteCourse(favCourse);
                    return new JsonResult(false);

                } else
                {
                    FavouriteCourses favCourse = new FavouriteCourses(_userdb.getUserByID(user), _db.GetCourseById(course));
                    _favdb.AddFavouriteCourse(favCourse);
                    return new JsonResult(true);
                }
            }
        }

        public ActionResult OnPostSetRate()
        {
            string rate = "";
            string course = "";

            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();

                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<RateWrapper>(requestBody);
                        if (obj != null)
                        {
                            rate = obj.Rate;
                            course = obj.Course;
                        }
                    }
                }

                User currentUser = _userdb.getUserByID(int.Parse(HttpContext.Request.Cookies["Id"]));
                //this.user = currentUser;
                Course currentCourse = _db.GetCourseById(int.Parse(course));
                
                if(_ratedb.GetRateByCourseAndName(currentCourse, currentUser) != null)
                {
                    Rate pushRate = _ratedb.GetRateByCourseAndName(currentCourse, currentUser);
                    pushRate.rate = int.Parse(rate);
                    pushRate.course = currentCourse;
                    pushRate.user = currentUser;
                    _ratedb.UpdateRate(pushRate);
                } else
                {
                    Rate pushRate = new Rate();
                    pushRate.rate = int.Parse(rate);
                    pushRate.course = currentCourse;
                    pushRate.user = currentUser;
                    _ratedb.AddRate(pushRate);
                }
                


                List<string> lstString = new List<string>
                {
                    rate
                };

                return new JsonResult(lstString);
            }
        }

        public ActionResult OnPostCreateComment()
        {

            string text = "";
            string user = "";
            string course = "";
            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();
                  
                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<CommentWrapper>(requestBody);
                        if (obj != null)
                        {
                            text = obj.Text;
                            user = obj.UserId;
                            course = obj.CourseId;
                        }
                    }
                }
            }
            User currentUser = _userdb.getUserByID(int.Parse(user));
            //this.user = currentUser;
            Course currentCourse = _db.GetCourseById(int.Parse(course));
            //this.course = course;
            Comment localComment = new Comment(currentUser, currentCourse, text);

            _dbcom.addComment(localComment);
            comments.Add(localComment);

            List<string> lstString = new List<string>
                {
                    currentUser.photo,
                    currentUser.login,
                    text
                };
            return new JsonResult(lstString);

        }

        public JsonResult OnGetComments(int id)
        {
            course = _db.GetCourseById(id);
            comments = _dbcom.getCommentsByCourseID(course).ToList();
            comments.Reverse();
            return new JsonResult(comments);
        }
 

        public IActionResult OnPost()
        {
            return Redirect("/Course");
        }

    }
}