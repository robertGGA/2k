using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semWork.Models
{
    public class FavouriteCourses
    {
       [Key]
        [Column(".fc_id")]
        public int fc_id { get; set; }
        [Required]
        public int user_id { get; set; }
        [Required]
        public Course course_id { get; set; }
    }
}
