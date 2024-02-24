using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    // Çıplak class kalmasın
    public class PersonManager : IApplicationService<Person>
    {
        public void ApplyForMAsk(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfPerson(Person person)// bu kişi vatandaş mı?
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;

            if (result)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Kişi Bilgisi Yanlış.");
                return false;

            }
        }

        public List<Person> GetAll()
        {
            return null;
        }
    }
}
