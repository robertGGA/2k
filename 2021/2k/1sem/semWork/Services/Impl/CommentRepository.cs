using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;
using System.Linq;

namespace semWork.Services.Impl
{
    public class CommentRepository: ICommentRepository
    {
        private readonly FuLearnContext context;

        public CommentRepository(FuLearnContext context)
        {
            this.context = context;
        }

        public Comment addComment(Comment comment)
        {
            context.Add(comment);
            context.SaveChanges();
            return comment;
        }

        public IEnumerable<Comment> getCommentsByCourseID(Course course)
        {
            var comments = (from comment in context.comments
                            where comment.course.course_id == course.course_id
                            select comment).ToList();
            return comments;
        }
    }
}
