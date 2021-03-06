using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;
using System.Linq;

namespace semWork.Services.Impl
{
    public class LessonRepository: ILessonRepository
    {
        private readonly FuLearnContext context;

        public LessonRepository(FuLearnContext context)
        {
            this.context = context;
        }

        public void CreateLesson(Lessons lesson)
        {
            context.Add(lesson);
            context.SaveChanges();
        }

        public Lessons GetLessonById(int id)
        {
            return context.lessons.Find(id);
        }

        public IEnumerable<Lessons> GetLessonsByCourseId(int id)
        {
            var lessons = (from lesson in context.lessons
                         where lesson.course.course_id == id
                         select lesson).ToList();
            return lessons;
        }
    }
}
