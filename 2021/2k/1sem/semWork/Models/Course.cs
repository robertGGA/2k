using System;
using System.Collections.Generic;

namespace semWork.Models
{
    public class Course
    {
        private int courseId { get; set; }
        private List<Lessons> lessons { get; set; }
        private string description { get; set; }
        private int rate { get; set; }
        private string photo { get; set; }
    }
}
