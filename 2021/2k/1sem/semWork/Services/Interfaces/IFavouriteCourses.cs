using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface IFavouriteCourses
    {
        public List<Course> GetCoursesByUserLogin (String login);
    }
}
