using Entities.Concrete;

namespace Business.Abstract;

public interface IInstructorService
{
    List<Instructor> GetAll();
    Instructor? GetById(int instructorId);
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(Instructor instructor);
}