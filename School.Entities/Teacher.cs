using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
