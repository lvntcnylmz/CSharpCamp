using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    private readonly List<Instructor> _instructors =
    [
        new Instructor(1, "Anders", "Hejlsberg", []),
        new Instructor(2, "James", "Gosling", []),
        new Instructor(3, "Graydon", "Hoare", [])
    ];

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor? GetById(int instructorId)
    {
        return _instructors.Find(i => i.Id == instructorId);
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        var instructorToUpdate = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
        if (instructorToUpdate != null)
        {
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
            instructorToUpdate.Courses = instructor.Courses;
        }
    }

    public void Delete(Instructor instructor)
    {
        var instructorToDelete = GetById(instructor.Id);
        if (instructorToDelete != null) _instructors.Remove(instructorToDelete);
    }
}