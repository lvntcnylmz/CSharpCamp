using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Adapters;

public class MernisServiceAdapter : IPersonCheckService
{
    public bool CheckIfRealPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        var result = client.TCKimlikNoDogrulaAsync(
                person.NationalIdentity,
                person.FirstName,
                person.LastName,
                person.DateOfBirthDate)
            .Result.Body.TCKimlikNoDogrulaResult;
        return result;
    }
}