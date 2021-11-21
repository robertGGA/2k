using System;
using System.Collections.Generic;

namespace semWork.Models
{
    public class FavouriteCourses
    {
        public int userId { get; set; }
        public List<Course> courses { get; set; }
    }
}
