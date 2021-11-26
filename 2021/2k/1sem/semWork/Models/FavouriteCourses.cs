using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class FavouriteCourses
    {
        [Key]
        public int userId { get; set; }

        public List<Course> courses { get; set; }
    }
}
