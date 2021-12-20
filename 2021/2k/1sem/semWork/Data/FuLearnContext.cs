using System;
using Microsoft.EntityFrameworkCore;
using semWork.Models;

namespace semWork.Data
{
    public class FuLearnContext : DbContext
    {
        public FuLearnContext(DbContextOptions<FuLearnContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Comment> comments { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<FavouriteCourses> favourite_courses { get; set; }
        public DbSet<Lessons> lessons { get; set; }
        public DbSet<SubLessons> subLessons { get; set; }
        public DbSet<Rate> rating { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Course>().ToTable("Courses");
        //    modelBuilder.Entity<User>().ToTable("Users");
        //    modelBuilder.Entity<Comment>().ToTable("Comments");
        //    modelBuilder.Entity<FavouriteCourses>().ToTable("FavouriteCourses");
        //    modelBuilder.Entity<Lessons>().ToTable("Lessons");
        //    modelBuilder.Entity<SubLessons>().ToTable("SubLessons");
        //}


    }
}
