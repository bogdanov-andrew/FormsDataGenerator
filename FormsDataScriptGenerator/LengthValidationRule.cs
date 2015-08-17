using System.Globalization;
using System.Windows.Controls;

namespace FormsDataScriptGenerator
{
    public class LengthValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false,null);
            }

            if (value.ToString().Length > 255)
            {
                return new ValidationResult(false, null);
            }

            return new ValidationResult(true, null);
        }
    }
}