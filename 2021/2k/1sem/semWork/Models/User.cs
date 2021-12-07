using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semWork.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        [Required(ErrorMessage ="Логин не может быть пустым")]
        public string login { get; set; }
        [Required]

        [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", ErrorMessage = "Пароль должен содержать как минимум 8 символов, 1 букву и 1 число")]
        public string password { get; set; }

        [ForeignKey("favourite_course")]
        public List<FavouriteCourses> favourite_course { get; set; }

        [Required(ErrorMessage = "Возраст не может быть пустым")]
        public int age { get; set; }
        public string photo { get; set; }

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
            favourite_course = user.favourite_course;
            age = user.age;
            photo = user.photo;
        }
       
    }

}
