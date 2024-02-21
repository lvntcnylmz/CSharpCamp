using Entities.Abstract;

namespace Entities.Concrete;

public class Instructor(int id, string firstName, string lastName, List<Course> courses) : BaseEntity(id)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public List<Course> Courses { get; set; } = courses;
}