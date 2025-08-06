using PersonalFinanceApp.Data.Models;
using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Mappers;

internal class CategoryMapper
{
    public static Category MapToDomain(CategoryDto dto)
    {
        return new Category
        {
            CategoryId = dto.CategoryId,
            Name = dto.Name,
        };
    }
    public static CategoryDto MapToDto(Category domain)
    {
        return new CategoryDto
        {
            CategoryId = domain.CategoryId,
            Name = domain.Name,
        };
    }
}