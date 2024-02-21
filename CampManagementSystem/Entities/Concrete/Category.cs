using Entities.Abstract;

namespace Entities.Concrete;

public class Category(int id, string name) : BaseEntity(id)
{
    public string Name { get; set; } = name;
}