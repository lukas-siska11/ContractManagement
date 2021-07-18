using System;
using System.ComponentModel.DataAnnotations;

namespace ContractManagement.Application.Validators
{
    public class DateNotInPast : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = (DateTime)value;
            return date >= DateTime.Now;
        }
    }
}
