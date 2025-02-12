namespace Domain.Entities;

public class Role:BaseEntity<Guid>
{
    public string Name { get; set; }
    public ICollection<UserRole>? UserRoles { get; set; }
}
