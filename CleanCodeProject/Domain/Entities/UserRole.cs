namespace Domain.Entities;

public class UserRole:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; } 

}
