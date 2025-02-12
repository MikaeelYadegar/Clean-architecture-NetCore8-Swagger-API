namespace Domain.Entities;

public class BaseEntity<T>
{
    public T Id { get; set; }
    public DateTime CreateDate { get; set; }
}
