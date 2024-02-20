using Entities.Concrete;

namespace Business.Abstract;

public interface IApplicantService
{
    void ApplyForMask(Person person);
}