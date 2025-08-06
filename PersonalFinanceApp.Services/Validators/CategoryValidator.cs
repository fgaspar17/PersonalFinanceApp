using FluentValidation;
using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Validators;

public class CategoryValidator : AbstractValidator<CategoryDto>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .MaximumLength(100).WithMessage("Category name cannot exceed 100 characters.");
    }
}