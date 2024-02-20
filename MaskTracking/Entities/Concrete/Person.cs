namespace Entities.Concrete;

public class Person(string firstName, string lastName, long nationalIdentity, int dateOfBirthDate)
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public long NationalIdentity { get; set; } = nationalIdentity;
    public int DateOfBirthDate { get; set; } = dateOfBirthDate;
}