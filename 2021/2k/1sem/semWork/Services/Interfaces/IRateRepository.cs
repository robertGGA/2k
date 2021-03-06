using System;
using System.Collections.Generic;
using semWork.Models;

namespace semWork.Services.Interfaces
{
    public interface IRateRepository
    {
        public void AddRate(Rate rate);

        public void UpdateRate(Rate rate);

        public IEnumerable<Rate> GetRatesByCourse(Course course);

        public Rate GetRateByCourseAndName(Course course, User user);
    }
}
