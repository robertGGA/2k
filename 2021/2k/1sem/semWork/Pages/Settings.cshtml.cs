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
using BC = BCrypt.Net.BCrypt;

namespace semWork.Pages
{
    public class SettingsModel : PageModel
    {
        private readonly IUserRepository _db;

        public SettingsModel(IUserRepository db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public ActionResult OnPostChangeUserParams()
        {
            
            string login = "";
            string password = "";
            string age = "";
            {
                MemoryStream stream = new MemoryStream();
                Request.Body.CopyTo(stream);
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream))
                {
                    string requestBody = reader.ReadToEnd();

                    if (requestBody.Length > 0)
                    {
                        var obj = JsonConvert.DeserializeObject<UserWrapper>(requestBody);
                        if (obj != null)
                        {
                            login = obj.Login;
                            password = obj.Password;
                            age = obj.Age;
                        }
                    }
                }
            }
            var pass = BC.HashPassword(password);
            var currentUser = _db.getUserByID(Convert.ToInt32(Request.Cookies["Id"]));
            currentUser.login = login;
            currentUser.password = pass;
            currentUser.age = int.Parse(age);
            _db.UpdateUserInfo(currentUser);
            //this.user = currentUser;
            //this.course = course;

            List<string> lstString = new List<string>
                {
                   
                };
            return new JsonResult(lstString);
        }
    }
}