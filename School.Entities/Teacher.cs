using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string LastName { get; set; }
        //regex/*****************************************
        public string Telephone { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public List<string> PortofolioURLs { get; set; }
        [Required, Range(0D, 1000000D)]
        public double Salary { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
