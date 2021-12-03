using System;
using System.ComponentModel.DataAnnotations;

namespace semWork.Models
{
    public class SubLessons
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string info { get; set; }
    }
}
