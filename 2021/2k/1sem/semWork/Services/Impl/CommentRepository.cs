using System;
using semWork.Models;
using semWork.Services.Interfaces;

namespace semWork.Services.Impl
{
    public class CommentRepository: ICommentRepository
    {
        public CommentRepository()
        {
        }

        public Comment addComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Comment getCommentByUserNameAndCourseName(string name, string course)
        {
            throw new NotImplementedException();
        }
    }
}
