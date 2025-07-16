using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceApp.Data.Models;

[Table("MoneyMovements")]
public class MoneyMovement
{
    public long MoneyMovementId { get; set; }
    public required string Description { get; set; }
    public DateTime MovementDate { get; set; }
    public decimal Amount { get; set; }
    public int CategoryId { get; set; }
    public int PaymentMethodId { get; set; }
    public int MovementTypeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool IsActive { get; set; }
    public Category Category { get; set; } = null!;
    public PaymentMethod PaymentMethod { get; set; } = null!;
    public MovementType MovementType { get; set; } = null!;
}