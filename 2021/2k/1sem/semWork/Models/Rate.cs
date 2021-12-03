using System;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class Rate
    {
        [Key]
        public int rate_id{ get; set; }

        public Course course_id { get; set; }

        public User user_id { get; set; }

        public int rate { get; set; }
        
    }
}
