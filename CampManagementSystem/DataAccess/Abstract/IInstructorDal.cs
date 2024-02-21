using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    Instructor? GetById(int instructorId);
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}