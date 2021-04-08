using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customers>
    {
        public CustomerValidator()
        {
            RuleFor(cs => cs.CompanyName).MinimumLength(0);
            RuleFor(cs => cs.CompanyName).NotEmpty();
      

        }
    }
}
