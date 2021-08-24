using Games.Common.Resources;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Games.Common.Validation
{
    public class PostalCodeAttribute : ValidationAttribute
    {
        public PostalCodeAttribute(string errorMessageResourceName)
        {
            ErrorMessageResourceName = errorMessageResourceName;
        }
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            string resourceVal = CommonResources.ResourceManager.GetString(ErrorMessageResourceName);
            ErrorMessage = resourceVal;


            //string pattern = @"^\d{5}-\d{4}|\d{5}|[A-Z]\d[A-Z] \d[A-Z]\d$";
            string pattern = @"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$";

            return Regex.IsMatch(value.ToString(), pattern);
        }
    }
}
