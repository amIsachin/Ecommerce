namespace Domain.Entities.BaseEntities;

public class AuditableBaseEntity
{
    public DateTime CreatedOn { get; set; } = DateTime.Now;
}
