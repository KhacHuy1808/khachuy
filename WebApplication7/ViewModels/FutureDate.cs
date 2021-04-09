using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WebApplication7.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object Value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(Value),
                "dd/M/yyyy",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}