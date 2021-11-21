using System;
using Microsoft.EntityFrameworkCore;
using semWork.Models;

namespace semWork.Data
{
    public class FuLearnContext : DbContext
    {
        public FuLearnContext(DbContextOptions<FuLearnContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<FavouriteCourses> FavouriteCourses { get; set; }
        public DbSet<Lessons> Lessons { get; set; }
        public DbSet<SubLessons> SubLessons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<FavouriteCourses>().ToTable("FavouriteCourses");
            modelBuilder.Entity<Lessons>().ToTable("Lessons");
            modelBuilder.Entity<SubLessons>().ToTable("SubLessons");
        }


    }
}
