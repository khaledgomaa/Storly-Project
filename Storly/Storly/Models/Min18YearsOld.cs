using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Storly.Models
{
    public class Min18YearsOld : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MemberShipTypeId == MemberShip.PayAsYouGo || customer.MemberShipTypeId == MemberShip.Unknown)
                return ValidationResult.Success;
            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is Required");
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18) ?
                ValidationResult.Success : new ValidationResult("Age Should Be at least 18");
            return base.IsValid(value, validationContext);
        }
    }
}