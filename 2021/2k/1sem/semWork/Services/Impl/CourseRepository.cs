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
        public IEnumerable<Course> GetAllCourses()
        {
            return context.courses;
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
