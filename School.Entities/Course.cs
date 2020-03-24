using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        [Required]
        public Type Type { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Description { get; set; }
        [Required, Range(0D, 100000.0D)]
        public double Price { get; set; }
        [Required]
        public DateTime StartAt { get; set; }
        [Required]
        public DateTime? EndAt { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
