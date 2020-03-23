using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities
{
    public class Discount
    { 
            public int DiscountId { get; set; }
            public string Title { get; set; }
            public double Percentage { get; set; }

        public virtual Student Student { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
