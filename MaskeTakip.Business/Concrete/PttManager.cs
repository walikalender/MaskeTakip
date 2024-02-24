using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class PttManager : ISupplierService<Person>
    {
        private readonly IApplicationService<Person> _applicationService;
        public PttManager(IApplicationService<Person> applicationService)
        {
            _applicationService=applicationService;
        }
        public void GiveMask(Person person)
        {
            var result = _applicationService.CheckIfPerson(person);
            if (result)
            {
                Console.WriteLine(person.FirstName+" için maske verildi.");
            }
            else
            {
                Console.WriteLine("Maske Verilemedi!");
            }

        }
    }
}
