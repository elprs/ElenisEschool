using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Entities.CustomValidations
{
    public class ValidationMethods
    {
        public static ValidationResult ValidateGreaterOrEqualToZero(double value, ValidationContext context)
        {
            bool isValid = true;
            if (value < 0D)
            {
                isValid = false;
            }
            if (isValid)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Format("The field {0} must be greater than or equal to zero", context.MemberName), new List<string> { context.MemberName });
            }
        }
    }
}
