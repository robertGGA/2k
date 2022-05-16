using System;
using semWork.Data;
using semWork.Models;
using semWork.Services.Interfaces;
using System.Linq;
using System.Collections.Generic;

namespace semWork.Services.Impl
{
    public class RateRepository : IRateRepository
    {

        private readonly FuLearnContext context;

        public RateRepository(FuLearnContext context)
        {
            this.context = context;
        }


        public void AddRate(Rate rate)
        {
            context.Add(rate);
            context.SaveChanges();
        }

        public IEnumerable<Rate> GetRatesByCourse(Course course)
        {
            var rate = (from rating in context.rating
                        where rating.course.course_id == course.course_id
                        select rating).ToList();
            return rate;
        }

        public Rate GetRateByCourseAndName(Course course, User user)
        {
            var rate = (from rating in context.rating
                        where rating.course.course_id == course.course_id && rating.user.user_id == user.user_id
                        select rating).FirstOrDefault();
            return rate;
        }

        public void UpdateRate(Rate rate)
        {
            context.Update(rate);
            context.SaveChanges();
        }
    }
}
