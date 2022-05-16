using System;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class Rate
    {
        [Key]
        public int rate_id{ get; set; }

        public Course course { get; set; }

        public User user { get; set; }

        public int rate { get; set; }
        
    }
}
