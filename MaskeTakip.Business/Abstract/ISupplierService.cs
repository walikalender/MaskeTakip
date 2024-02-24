using MaskeTakip.Entities.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Abstract
{
    //yeni özellik gelince mevcut koda dokunma(eczane)
    public interface ISupplierService<T>
    {
        void GiveMask(T entity);
    }
}
