using Games.Common.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Games.ViewModel.Validation
{
    public class PasswordRequirementsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var errors = new List<string>();
            var password = (string)value;

            if (!string.IsNullOrEmpty(password))
            {
                if (password.Length < 8)
                {
                    errors.Add(CommonResources.PasswordLengthMinimumof8Characters);
                }

                if (password.ToLower().Equals(password))
                {
                    errors.Add(CommonResources.MinimunOf1Uppercase);
                }

                if (password.ToUpper().Equals(password))
                {
                    errors.Add(CommonResources.MinimunOf1Lowercase);
                }

                if (!password.Any(x => char.IsDigit(x)))
                {
                    errors.Add(CommonResources.MinimunOf1Number);
                }

                if (!password.Any(x => ! char.IsLetterOrDigit(x) && ! char.IsWhiteSpace(x)))
                {
                    errors.Add(CommonResources.MinimunOf1SpecialCharacter);
                }
            }

            if (errors.Count == 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(string.Join(' ', errors));
            }
        }

    }
}
