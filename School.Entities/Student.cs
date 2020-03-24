using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string LastName { get; set; }
        //regex/*****************************************
        public string Telephone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public virtual ICollection<Course> Courses { get; set; } 
        public virtual ICollection<Discount> Discounts { get; set; }    
    }
}
