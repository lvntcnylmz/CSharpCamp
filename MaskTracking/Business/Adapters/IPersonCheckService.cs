using Entities.Concrete;

namespace Business.Adapters;

public interface IPersonCheckService
{
    bool CheckIfRealPerson(Person person);
}