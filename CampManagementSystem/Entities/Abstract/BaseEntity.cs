namespace Entities.Abstract;

public abstract class BaseEntity(int id)
{
    public int Id { get; set; } = id;
}