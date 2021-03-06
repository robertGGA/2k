using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> GetAllCourses();

        public Course GetCourseById(int id);

        public void CreateCourse(Course course);

    }
}
