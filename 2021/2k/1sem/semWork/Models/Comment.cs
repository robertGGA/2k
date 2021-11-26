using System;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class Comment
    {
        [Key]
        public int personId { get; set; }

        public User userId { get; set; }
        public Course courseId { get; set; }
        public string text { get; set; }
    }
}
