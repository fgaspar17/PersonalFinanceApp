using Microsoft.EntityFrameworkCore;
using PersonalFinanceApp.Data;
using PersonalFinanceApp.Services.DTOs;
using PersonalFinanceApp.Services.Mappers;

namespace PersonalFinanceApp.Services.Services;

public class PaymentMethodService : IPaymentMethodService
{
    private readonly PersonalFinanceAppContext _context;

    public PaymentMethodService(PersonalFinanceAppContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentMethodDto>> GetAllPaymentMethodsAsync(CancellationToken ct)
    {
        return await _context.PaymentMethods
            .Select(pm => PaymentMethodMapper.MapToDto(pm))
            .ToListAsync(ct);
    }

    public async Task<PaymentMethodDto?> GetPaymentMethodByIdAsync(int id, CancellationToken ct)
    {
        var paymentMethod = await _context.PaymentMethods
            .SingleOrDefaultAsync(pm => pm.PaymentMethodId == id, ct);

        if (paymentMethod == null)
        {
            return null;
        }

        return PaymentMethodMapper.MapToDto(paymentMethod);
    }

    public async Task<PaymentMethodDto> CreatePaymentMethodAsync(PaymentMethodDto paymentMethodDto, CancellationToken ct)
    {
        var paymentMethod = PaymentMethodMapper.MapToDomain(paymentMethodDto);
        paymentMethod.CreatedAt = DateTime.UtcNow;
        paymentMethod.UpdatedAt = null;
        paymentMethod.IsActive = true;
        _context.PaymentMethods.Add(paymentMethod);
        await _context.SaveChangesAsync(ct);
        return PaymentMethodMapper.MapToDto(paymentMethod);
    }

    public async Task<PaymentMethodDto?> UpdatePaymentMethodAsync(int id, PaymentMethodDto paymentMethodDto, CancellationToken ct)
    {
        var existingPaymentMethod = await _context.PaymentMethods
            .SingleOrDefaultAsync(pm => pm.PaymentMethodId == id, ct);
        if (existingPaymentMethod == null)
        {
            return null;
        }
        existingPaymentMethod.Name = paymentMethodDto.Name;
        existingPaymentMethod.UpdatedAt = DateTime.UtcNow;
        _context.PaymentMethods.Update(existingPaymentMethod);
        await _context.SaveChangesAsync(ct);
        return PaymentMethodMapper.MapToDto(existingPaymentMethod);
    }

    public async Task<bool> DeletePaymentMethodAsync(int id, CancellationToken ct)
    {
        var paymentMethod = await _context.PaymentMethods
            .SingleOrDefaultAsync(pm => pm.PaymentMethodId == id, ct);
        if (paymentMethod == null)
        {
            return false;
        }
        paymentMethod.UpdatedAt = DateTime.UtcNow;
        paymentMethod.IsActive = false;
        _context.PaymentMethods.Update(paymentMethod);
        await _context.SaveChangesAsync(ct);
        return true;
    }
}