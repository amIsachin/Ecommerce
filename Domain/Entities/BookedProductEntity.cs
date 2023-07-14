using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class BookedProductEntity
{
    [Key]
    public int BookingId { get; set; }

    public int ProductId { get; set; }

    public int UserId { get; set; }

    public ProductEntity? Product { get; set; }

    public UserEntity? User { get; set; }
}
