namespace Domain.Entities;

public class User:BaseEntity<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string NationalCode { get; set; }
    public string Password {  get; set; }
    public ICollection<UserRole>?UserRoles { get; set; }
}
