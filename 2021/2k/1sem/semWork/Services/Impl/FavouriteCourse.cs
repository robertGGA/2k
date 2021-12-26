using System;
using System.Collections.Generic;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;
using System.Linq;

namespace semWork.Services.Impl
{
    public class FavouriteCourse: IFavouriteCourses
    {
        private readonly FuLearnContext context;

        public FavouriteCourse(FuLearnContext context)
        {
            this.context = context;
        }

        public FavouriteCourses GetCourseByUserIdAndCourseId(int courseId, int userId)
        {
            var favCourses = (from favCourse in context.favourite_courses
                              where favCourse.course.course_id == courseId && favCourse.user.user_id == userId
                              select favCourse).ToList().FirstOrDefault();
            return favCourses;
        }

        public IEnumerable<FavouriteCourses> GetCoursesListByUserId(int id)
        {
            var favCourses = (from favCourse in context.favourite_courses
                              where favCourse.course.course_id == id
                            select favCourse).ToList();
            return favCourses;
        }

        public Boolean IsExists(int courseId, int userId)
        {
            return GetCourseByUserIdAndCourseId(courseId, userId) == null ? false : true;


        }

        public void DeleteFavouriteCourse(FavouriteCourses favouriteCourse)
        {
            context.favourite_courses.Attach(favouriteCourse);
            context.favourite_courses.Remove(favouriteCourse);
                    
            context.SaveChanges();
        }

        public void AddFavouriteCourse(FavouriteCourses favcourse)
        {
            context.Attach(favcourse);
            context.Add(favcourse);
            context.SaveChanges();
        }
    }
}
