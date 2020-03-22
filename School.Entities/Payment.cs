using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Payment
    {

        public int PaymentId { get; set; }
        public bool IsDone { get; set; }

        public virtual Discount Discount { get; set; }
    }
}
