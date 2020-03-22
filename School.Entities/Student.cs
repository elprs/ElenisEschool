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

        public virtual ICollection<Course> Courses { get; set; } 
        public virtual ICollection<Assignment> Assignments { get; set; } 
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public virtual Payment Payment { get; set; }
        
    }
}
