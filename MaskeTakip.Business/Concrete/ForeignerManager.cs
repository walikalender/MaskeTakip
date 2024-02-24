using MaskeTakip.Business.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Concrete
{
    public class ForeignerManager : IApplicationService<Foreign>
    {
        public void ApplyForMAsk(Foreign foreign)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfPerson(Foreign foreign)
        {
            if (foreign.ForeignIdentityNumber==(foreign.FirstName.Length+foreign.LastName.Length))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Yabancı Kişi Bilgisi Yanlış");
                return false;
            }

        }

        public List<Foreign> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
