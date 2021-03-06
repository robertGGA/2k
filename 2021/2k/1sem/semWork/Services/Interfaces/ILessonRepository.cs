using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface ILessonRepository
    {
        public IEnumerable<Lessons> GetLessonsByCourseId(int id);

        public Lessons GetLessonById(int id);

        public void CreateLesson(Lessons lesson);
    }
}
