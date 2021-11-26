using System;
using System.Collections.Generic;

namespace semWork.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public List<Lessons> lessons { get; set; }
        public string description { get; set; }
        public int rate { get; set; }
        public string photo { get; set; }
    }
}
