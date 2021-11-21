using System;
namespace semWork.Models
{
    public class Comment
    {
        private int commentId { get; set; }
        private User userId { get; set; }
        private Course courseId { get; set; }
        private string text { get; set; }
    }
}
