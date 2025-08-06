using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalFinanceApp.Data.Models;

[Table("Categories")]
public class Category
{
    public int CategoryId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ModifiedAt { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<MoneyMovement> MoneyMovements { get; set; } = new List<MoneyMovement>();
}