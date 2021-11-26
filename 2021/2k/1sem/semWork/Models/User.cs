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
        public List<FavouriteCourses> favouriteCourse { get; set; }
        public int age { get; set; }
        public string photo { get; set; }
    }

}
