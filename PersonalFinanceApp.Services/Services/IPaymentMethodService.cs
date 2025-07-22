using PersonalFinanceApp.Services.DTOs;

namespace PersonalFinanceApp.Services.Services;

public interface IPaymentMethodService
{
    Task<PaymentMethodDto> CreatePaymentMethodAsync(PaymentMethodDto paymentMethodDto, CancellationToken ct);
    Task<bool> DeletePaymentMethodAsync(int id, CancellationToken ct);
    Task<List<PaymentMethodDto>> GetAllPaymentMethodsAsync(CancellationToken ct);
    Task<PaymentMethodDto?> GetPaymentMethodByIdAsync(int id, CancellationToken ct);
    Task<PaymentMethodDto?> UpdatePaymentMethodAsync(int id, PaymentMethodDto paymentMethodDto, CancellationToken ct);
}