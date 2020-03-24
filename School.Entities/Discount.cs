using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        [Required, MaxLength(50), MinLength(2)]
        public string Title { get; set; }
        public double Percentage { get; set; }
        public virtual Student Student { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
