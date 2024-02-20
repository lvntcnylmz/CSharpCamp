using Business.Adapters;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonCheckManager : IPersonCheckService
{
    public bool CheckIfRealPerson(Person person)
    {
        return true;
    }
}