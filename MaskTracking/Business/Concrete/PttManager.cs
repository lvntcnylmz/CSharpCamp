using Business.Abstract;
using Business.Adapters;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager(IPersonCheckService personCheckService) : ISupplierService
{
    
    public void GiveMask(Person person)
    {
        if (personCheckService.CheckIfRealPerson(person))
        {
            Console.WriteLine(person.FirstName + " was given a mask");
        }
        else
        {
            throw new Exception("Error: Not a valid person.");
        }
    }
}