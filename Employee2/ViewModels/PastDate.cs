using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Employee2.Models
{
    public class PastDate:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "d MMM yyyy",
                CultureInfo.CurrentUICulture, 
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime < DateTime.Now);
        }
    }
}