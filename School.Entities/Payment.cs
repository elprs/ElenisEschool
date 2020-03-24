using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace School.Entities
{
    public class Payment
    {
        [ForeignKey("Discount")]
        public int PaymentId { get; set; }
        public double TotalAmount { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
        public virtual Discount Discount { get; set; }
    }
}
