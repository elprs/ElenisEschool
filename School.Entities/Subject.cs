using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace School.Entities
{
    public class Subject
    {
        [ForeignKey("Assignment")]
        public int SubjectId { get; set; }
        [Required, MinLength(2), MaxLength(50)]
        public string Title { get; set; }
        public virtual Course Course { get; set; }
        public virtual Assignment Assignment { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }


    }
}
