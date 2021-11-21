using System;
using System.Collections.Generic;

namespace semWork.Models
{
    public class User
    {
        private int id { get; set; }
        private string login { get; set; }
        private string password { get; set; }
        private List<FavouriteCourses> favouriteCourse { get; set; }
        private DateTime yearOfBirth { get; set; }
        private string photo { get; set; }
    }
}
