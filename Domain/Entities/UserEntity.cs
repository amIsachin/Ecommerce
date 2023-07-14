using Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class UserEntity : PersonBaseEntity
{
    [Key]
    public int UserId { get; set; }

    public int PhoneNumber { get; set; }

    public string Address { get; set; } = string.Empty;

    public ICollection<BookedProductEntity>? BookedProductEntity { get; set; }
}
