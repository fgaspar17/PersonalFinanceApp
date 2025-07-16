using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PersonalFinanceApp.Data.Models;

[Table("MovementTypes")]
public class MovementType
{
    public int MovementTypeId { get; set; }
    public required string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public bool IsActive { get; set; }
    public ICollection<MoneyMovement> MoneyMovements { get; set; } = new List<MoneyMovement>();
}