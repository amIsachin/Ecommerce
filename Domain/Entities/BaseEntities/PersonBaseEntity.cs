namespace Domain.Entities.BaseEntities;

public class PersonBaseEntity : AuditableBaseEntity
{
    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    public string Gender { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;
}
