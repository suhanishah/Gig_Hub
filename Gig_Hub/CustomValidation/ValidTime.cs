using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Gig_Hub.CustomValidation
{
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime time;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                 "HH:MM",
                 CultureInfo.CurrentCulture,
                 DateTimeStyles.None, out time);

            return (isValid);
        }
    }
}