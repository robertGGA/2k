using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;

namespace semWork.Services.Impl
{
    public class CourseRepository: ICourseRepository
    {
        private readonly FuLearnContext context;

        public CourseRepository(FuLearnContext context)
        {
            this.context = context;
        }

        public void CreateCourse(Course course)
        {
            context.Add(course);
            context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return context.courses;
        }

        public Course GetCourseById(int id)
        {
            return context.courses.Find(id);
        }

    }
}
