using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Student
    {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }

        public virtual ICollection<Course> Courses { get; set; } 
        public virtual ICollection<Discount> Discounts { get; set; }
        
    }
}
