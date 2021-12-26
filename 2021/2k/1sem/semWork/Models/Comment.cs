using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semWork.Models
{
    public class Comment
    {
        [Key]
        public int comment_id { get; set; }
        [Required]
        public virtual User user { get; set; }
        [Required]
        public Course course { get; set; }
        [Required]
        public string commenttext { get; set; }

        public Comment()
        {

        }

        public Comment(User user, Course course, string comment)
        {
            this.user = user;
            this.course = course;
            this.commenttext = comment;
        }
    }

    
}
