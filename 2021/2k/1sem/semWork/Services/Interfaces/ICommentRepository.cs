using System;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface ICommentRepository
    {
        public Comment getCommentByUserNameAndCourseName(string name, string course);

        public Comment addComment(Comment comment);
    }
}
