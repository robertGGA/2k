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
            try
            {
                var course = GetCourseByUserIdAndCourseId(courseId, userId);
                return true;
            } catch(Exception e)
            {
                return false;
            }
        }

        public void DeleteFavouriteCourse(FavouriteCourses favouriteCourse)
        {
            context.favourite_courses.Attach(favouriteCourse);
            context.favourite_courses.Remove(favouriteCourse);
                    
            context.SaveChanges();
        }

        public FavouriteCourses AddFavouriteCourse(FavouriteCourses favourite_courses)
        {
            context.Add(favourite_courses);
            context.SaveChanges();
            return favourite_courses;
        }
    }
}
