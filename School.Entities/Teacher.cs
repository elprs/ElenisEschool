using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using School.Entities.CustomValidations;

namespace School.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required field"), MaxLength(50), MinLength(2)]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber), Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Required field")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                    ErrorMessage = "Entered phone format is not valid.")]
        public string Telephone { get; set; }
        [Required(ErrorMessage = "Required field"), EmailAddress]
        public string Email { get; set; }
        public List<string> PortofolioURLs { get; set; }
       // [Required, Range(0D, double.MaxValue)]
       [CustomValidation(typeof(ValidationMethods), "ValidateGreaterOrEqualToZero")]
        public double Salary { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
