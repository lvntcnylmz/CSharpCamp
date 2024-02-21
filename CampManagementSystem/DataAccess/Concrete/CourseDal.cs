using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    private readonly List<Course> _courses =
    [
        new Course(1, "CSharp", 2, 2, "CSharp Camp", 666.00),
        new Course(2, "Java", 2, 2, "Java Camp", 666.00),
        new Course(3, "Rust", 2, 2, "Rust Camp", 666.00),
    ];

    public List<Course> GetAll()
    {
        return _courses;
    }

    public Course? GetById(int courseId)
    {
        return _courses.Find(c => c.Id == courseId);
    }

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Update(Course course)
    {
        var courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
        if (courseToUpdate != null)
        {
            courseToUpdate.Name = course.Name;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.Description = course.Description;
            courseToUpdate.Price = course.Price;
        }
    }

    public void Delete(Course course)
    {
        var courseToDelete = _courses.SingleOrDefault(c => c.Id == course.Id);
        if (courseToDelete != null) _courses.Remove(courseToDelete);
    }
}