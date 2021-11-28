using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public List<FavouriteCourses>? favouriteCourse { get; set; }
        public int age { get; set; }
        public string? photo { get; set; }

        public User(string login, string password, int age)
        {
            this.login = login;
            this.password = password;
            this.age = age;
        }

        public User() { }

        public User(User user)
        {
            user_id = user.user_id;
            login = user.login;
            password = user.password;
            favouriteCourse = user.favouriteCourse;
            age = user.age;
            photo = user.photo;
        }
       
    }

}
