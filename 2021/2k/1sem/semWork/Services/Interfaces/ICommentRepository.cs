using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface ICommentRepository
    {
        public IEnumerable<Comment> getCommentsByCourseID(Course course);

        public Comment addComment(Comment comment);
    }
}
