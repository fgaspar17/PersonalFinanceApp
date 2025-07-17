namespace PersonalFinanceApp.Services.DTOs;

public class PaymentMethodDto
{
    public int PaymentMethodId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}