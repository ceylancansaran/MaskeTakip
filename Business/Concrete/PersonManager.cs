using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager : IApplicantService //Kalıtım
{
    //maske için başvur metodu. parametre olarak person u verdik
    //kaç kişi maske aldı, kaç kişi almadı, daha önce maske almış mı gibi kontroller eklenecek

    //encapsulation
    public void ApplyForMask(Person person) //parametre olarak tüm alanları türleri ile buraya yazabilirdik. Ama direkt buraya parametreleri tek tek yazarsak farklı yerlerde sorun oluşacak.
    {
        
    }

    public List<Person> GetList() 
    {
        return null;
    }

    public bool CheckPerson(Person person) //Mernis e bağlanarak Kişi doğrulaması yapılacak
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    }
}
