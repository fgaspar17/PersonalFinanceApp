using FluentValidation;
using Microsoft.EntityFrameworkCore;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Mappers;

namespace PersonalFinanceApp.Services.Services;

public class CategoryService : ICategoryService
{
    private readonly PersonalFinanceAppContext _context;
    private readonly IValidator<CategoryDto> _validator;

    public CategoryService(PersonalFinanceAppContext context, IValidator<CategoryDto> validator)
    {
        _context = context;
        _validator = validator;
    }

    public async Task<List<CategoryDto>> GetAllCategoriesAsync(CancellationToken ct)
    {
        return await _context.Categories
            .Select(c => CategoryMapper.MapToDto(c))
            .ToListAsync(ct);
    }

    public async Task<CategoryDto?> GetCategoryByIdAsync(int id, CancellationToken ct)
    {
        var category = await _context.Categories
            .SingleOrDefaultAsync(c => c.CategoryId == id, ct);

        if (category == null)
        {
            return null;
        }

        return CategoryMapper.MapToDto(category);
    }

    public async Task<CategoryDto> CreateCategoryAsync(CategoryDto categoryDto, CancellationToken ct)
    {
        var validationResult = _validator.Validate(categoryDto);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        // TODO: Check to be UNIQUE

        var category = CategoryMapper.MapToDomain(categoryDto);
        category.CreatedAt = DateTime.UtcNow;
        category.ModifiedAt = null;
        category.IsActive = true;
        _context.Categories.Add(category);
        await _context.SaveChangesAsync(ct);
        return CategoryMapper.MapToDto(category);
    }

    public async Task<CategoryDto?> UpdateCategoryAsync(int id, CategoryDto categoryDto, CancellationToken ct)
    {
        var validationResult = _validator.Validate(categoryDto);
        if (!validationResult.IsValid)
        {
            throw new ValidationException(validationResult.Errors);
        }

        // TODO: Check to be UNIQUE

        var existingCategory = await _context.Categories
            .SingleOrDefaultAsync(c => c.CategoryId == id, ct);
        if (existingCategory == null)
        {
            return null;
        }
        existingCategory.Name = categoryDto.Name;
        existingCategory.ModifiedAt = DateTime.UtcNow;
        _context.Categories.Update(existingCategory);
        await _context.SaveChangesAsync(ct);
        return CategoryMapper.MapToDto(existingCategory);
    }

    public async Task<bool> DeleteCategoryAsync(int id, CancellationToken ct)
    {
        var category = await _context.Categories
            .SingleOrDefaultAsync(c => c.CategoryId == id, ct);
        if (category == null)
        {
            return false;
        }
        category.ModifiedAt = DateTime.UtcNow;
        category.IsActive = false;
        _context.Categories.Update(category);
        await _context.SaveChangesAsync(ct);
        return true;
    }
}