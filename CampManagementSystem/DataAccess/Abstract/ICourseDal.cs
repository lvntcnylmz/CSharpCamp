using Entities.Concrete;

namespace DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    Course? GetById(int courseId);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}