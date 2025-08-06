using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Services
{
    public interface ICategoryService
    {
        Task<CategoryDto> CreateCategoryAsync(CategoryDto categoryDto, CancellationToken ct);
        Task<bool> DeleteCategoryAsync(int id, CancellationToken ct);
        Task<List<CategoryDto>> GetAllCategoriesAsync(CancellationToken ct);
        Task<CategoryDto?> GetCategoryByIdAsync(int id, CancellationToken ct);
        Task<CategoryDto?> UpdateCategoryAsync(int id, CategoryDto categoryDto, CancellationToken ct);
    }
}