using Domain.Entities.BaseEntities;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class UserEntity : PersonBaseEntity
{
    [Key]
    public int UserId { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;

    //public ICollection<BookedProductEntity>? BookedProductEntity { get; set; }
}
