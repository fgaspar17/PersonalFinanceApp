using FluentValidation;
using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Validators;

public class PaymentMethodValidator : AbstractValidator<PaymentMethodDto>
{
    public PaymentMethodValidator()
    {
        RuleFor(pm => pm.Name)
            .NotEmpty().WithMessage("Payment method name is required.")
            .MaximumLength(100).WithMessage("Payment method name cannot exceed 100 characters.");
    }
}