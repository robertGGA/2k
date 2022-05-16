using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using semWork.dto;
using semWork.Services.Interfaces;
using Microsoft.AspNetCore;


namespace semWork.Pages
{
    public class CreateCourseModel : PageModel
    {
        private readonly ICourseRepository _db;
        private readonly IHostingEnvironment _environment;

        public CreateCourseModel(ICourseRepository db, IHostingEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        public void OnGet()
        {

        }

        public void OnPostEmpty()
        {
            Console.WriteLine("works");
        }

        public ActionResult OnPostGenerateCourse()
        {
            string name = "";
            string description = "";

            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();

                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<CourseWrapper>(requestBody);
                        if (obj != null)
                        {
                            name = obj.Name;
                            description = obj.Description;
                        }
                    }
                }
            }
           
                List<string> lstString = new List<string>
                    {
                        name,
                        description
                    };

            return new JsonResult(lstString);

        }
    }
}