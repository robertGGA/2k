using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class Course
    {
        [Key]
        public int course_id { get; set; }

        [Required]
        public string name { get; set; }

        public List<Lessons> lesson_id { get; set; }

        [Required]
        public string description { get; set; }
        
        public List<Rate> rate { get; set; }
        [Required]
        public string photo { get; set; }
    }
}
