using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Entities
{
    public class Subject
    {
        [ForeignKey("Assignment")]
        public int SubjectId { get; set; }
        public string Title { get; set; }

        public virtual Course Course { get; set; }
        public virtual Assignment Assignment { get; set; }


    }
}
