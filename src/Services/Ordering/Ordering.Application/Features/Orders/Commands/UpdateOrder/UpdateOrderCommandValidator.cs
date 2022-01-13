﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator:AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(i => i.UserName)
                .NotEmpty().WithMessage("{UserName} is required.")  
                .NotNull()
                .MaximumLength(50).WithMessage("{UserName} must not exceed 50 characters.");

            RuleFor(i => i.EmailAddress)
               .NotEmpty().WithMessage("{EmailAddress} is required.")
               .EmailAddress().WithMessage("{EmailAddress} must be in an valid email address format.");

            RuleFor(i => i.TotalPrice)
               .NotEmpty().WithMessage("{TotalPrice} is required.")
               .GreaterThan(0).WithMessage("{TotalPrice} should be greater than zero.");
        }
    }
}
