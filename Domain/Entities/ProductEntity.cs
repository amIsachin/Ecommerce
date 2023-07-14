using Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class ProductEntity : AuditableBaseEntity
{
    [Key]
    public int ProductId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public ICollection<BookedProductEntity>? BookedProductEntity { get; set; }
}