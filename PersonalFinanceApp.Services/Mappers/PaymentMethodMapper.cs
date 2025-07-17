using PersonalFinanceApp.Data.Models;
using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Mappers;

internal class PaymentMethodMapper
{
    public static PaymentMethod MapToDomain(PaymentMethodDto dto)
    {
        return new PaymentMethod
        {
            PaymentMethodId = dto.PaymentMethodId,
            Name = dto.Name,
            CreatedAt = dto.CreatedAt,
            UpdatedAt = dto.UpdatedAt
        };
    }
    public static PaymentMethodDto MapToDto(PaymentMethod domain)
    {
        return new PaymentMethodDto
        {
            PaymentMethodId = domain.PaymentMethodId,
            Name = domain.Name,
            CreatedAt = domain.CreatedAt,
            UpdatedAt = domain.UpdatedAt
        };
    }
}