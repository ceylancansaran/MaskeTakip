using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService //burada herhangi bir implement yada inherits olmaması bir zaafiyet oluşturuyor.
{
    private IApplicantService _applicantService; //Bu bir field. Field lar class içerisinde _ ile yazılır. 
    public PttManager(IApplicantService applicantService) //constructor(oluşturucu) (bu class başladığında ihtiyaç duyduğumuz için constructor oluşturduk.) PttManager i new lediğimde constructor çalışır.
        //burada tanımladığım applicantService a bu blok dışında erişemeyeceğim için _applicantService i global alanda tanımlıyoruz.
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        //PersonManager personManager = new PersonManager();  
        //bu şekilde PersonManager sınıfına bağımlı halde oluyor.Bunun yerine aşağıdaki gibi bu sınıfın interface ini kullanıyoruz.

        if (_applicantService.CheckPerson(person)) 
        {
            Console.WriteLine(person.FirstName + " için maske verildi");
        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske verilemedi");
        }
    }
}
