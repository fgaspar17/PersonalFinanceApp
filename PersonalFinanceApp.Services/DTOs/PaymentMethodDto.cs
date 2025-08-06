namespace PersonalFinanceApp.Services.DTOs;

public class PaymentMethodDto
{
    public int PaymentMethodId { get; set; }
    public required string Name { get; set; }
}