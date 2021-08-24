using System.ComponentModel.DataAnnotations;

namespace Games.Common.Validation
{
    public class OptionalMinLengthAttribute : MinLengthAttribute
    {
        public OptionalMinLengthAttribute(int length) : base(length)
        {
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }
            return base.IsValid(value, validationContext);
        }
    }
}
