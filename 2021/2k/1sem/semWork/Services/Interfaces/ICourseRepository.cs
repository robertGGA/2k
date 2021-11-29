using System;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface ICourseRepository
    {
        public Course GetCourseByName(string name);
    }
}
