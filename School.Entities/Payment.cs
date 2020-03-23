using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Entities
{
    public class Payment
    {
        [ForeignKey("Discount")]
        public int PaymentId { get; set; }
        public bool IsDone { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
