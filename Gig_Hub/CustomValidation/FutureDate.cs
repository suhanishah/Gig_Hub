﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Gig_Hub.CustomValidation
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
               "dd/MM/yyyy",
               CultureInfo.CurrentCulture,
               DateTimeStyles.None, out date);
           
            return (isValid && (date > DateTime.Now));
        }
    }
}