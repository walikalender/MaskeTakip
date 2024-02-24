using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class MedicalManager : ISupplierService<Foreign>
    {
        private readonly IApplicationService<Foreign> _applicationService;
        public MedicalManager(IApplicationService<Foreign> applicationService)
        {
            _applicationService=applicationService;
        }

        public void GiveMask(Foreign foreign)
        {
            var result = _applicationService.CheckIfPerson(foreign);
            if (result)
            {
                Console.WriteLine(foreign.FirstName+" için maske verildi.");
            }
            else
            {
                Console.WriteLine("Maske Verilemedi");
            }
        }
    }
}
