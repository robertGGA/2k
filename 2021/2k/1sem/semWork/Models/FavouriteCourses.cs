using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semWork.Models
{
    [Table("favourite_courses")]
    public class FavouriteCourses
    {
       [Key]
        [Column("fc_id")]
        public int fc_id { get; set; }
        [ForeignKey("user_id")]
        public User user { get; set; }
        [ForeignKey("course_id")]
        public Course course { get; set; }

        public FavouriteCourses() { }

        public FavouriteCourses(User user, Course course)
        {
            this.user = user;
            this.course = course;
        }
    }

   
}
