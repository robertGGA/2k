using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var comments = context.comments
                       .Where(b => b.course.course_id == course.course_id)
                       .Include(b => b.user)
                       .ToList();
            return comments;
        }
    }
}
