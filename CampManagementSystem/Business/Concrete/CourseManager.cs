using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CourseManager(ICourseDal courseDal) : ICourseService
{
    private readonly ICourseDal _courseDal = courseDal;
    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public Course? GetById(int courseId)
    {
        return _courseDal.GetById(courseId);
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }
}