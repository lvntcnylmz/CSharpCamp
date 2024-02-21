using Entities.Abstract;

namespace Entities.Concrete;

public class Course(int id, string name, int categoryId, int instructorId, string description, double price) : BaseEntity(id)
{
    public string Name { get; set; } = name;
    public int CategoryId { get; set; } = categoryId;
    public int InstructorId { get; set; } = instructorId;
    public string Description { get; set; } = description;
    public double Price { get; set; } = price;
}