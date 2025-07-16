using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceApp.Data.Models;

[Table("PaymentMethods")]
public class PaymentMethod
{
    public int PaymentMethodId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; }
    public ICollection<MoneyMovement> MoneyMovements { get; set; } = new List<MoneyMovement>();
}