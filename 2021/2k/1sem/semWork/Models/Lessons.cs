using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class Lessons
    {
        [Key]
        public int lesson_id { get; set; }
        public Course course { get; set; }
        public string description { get; set; }
        public string page { get; set; }
        public List<SubLessons> sublessons { get; set; }

        public Lessons() { }

        public Lessons(string lesson)
        {
            this.page = lesson;
        }
    }
}