using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace semWork.Models
{
    public class Comment
    {
        [Key]
        public int comment_id { get; set; }
        public User user { get; set; }
        public Course course { get; set; }
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
