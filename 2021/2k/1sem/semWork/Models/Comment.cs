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
    }
}
