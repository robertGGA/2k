using System;
using System.Collections.Generic;

namespace semWork.Models
{
    public class Lessons
    {
        private int lessonId { get; set; }
        private string description { get; set; }
        private string page { get; set; }
        private List<SubLessons> sublessons { get; set; }
    }
}