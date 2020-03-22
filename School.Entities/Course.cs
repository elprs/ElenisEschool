using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
   public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
