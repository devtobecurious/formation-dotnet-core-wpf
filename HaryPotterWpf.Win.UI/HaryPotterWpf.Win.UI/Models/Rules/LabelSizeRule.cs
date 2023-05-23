using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HaryPotterWpf.Win.UI.Models.Rules
{
    public class LabelSizeRule : ValidationRule
    {
        public int MinChars { get; set; } = 3;

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value == null)
            {
                return new ValidationResult(false, "Empty");
            }

            string? content = value as string;

            if (content?.Length < this.MinChars)
            {
                return new(false, "Size too small");
            }

            return ValidationResult.ValidResult;
        }
    }
}
