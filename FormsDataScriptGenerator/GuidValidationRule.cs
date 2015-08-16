using System;
using System.Globalization;
using System.Windows.Controls;

namespace FormsDataScriptGenerator
{
    public class GuidValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return new ValidationResult(false, null);
            }

            if (string.IsNullOrEmpty((string) value))
            {
                return new ValidationResult(false, null);
            }

            Guid guid = new Guid();
            if (Guid.TryParse((string)value, out guid))
            {
                return new ValidationResult(true, null);
            }

            return new ValidationResult(false,"It should be guid");
        }
    }
}