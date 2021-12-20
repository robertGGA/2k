using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface IFavouriteCourses
    {
        public IEnumerable<FavouriteCourses> GetCoursesListByUserId(int id);

        public FavouriteCourses GetCourseByUserIdAndCourseId(int courseId, int userId);

        public Boolean IsExists(int courseId, int userId);

        public void DeleteFavouriteCourse(FavouriteCourses favouriteCourse);

        public FavouriteCourses AddFavouriteCourse(FavouriteCourses favouriteCourse);
    }
}
