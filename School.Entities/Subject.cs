using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Title { get; set; }

        public virtual Course Course { get; set; }
        public virtual Assignment Assignment { get; set; }


    }
}
