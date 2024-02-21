using Entities.Concrete;

namespace Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    Course? GetById(int courseId);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}