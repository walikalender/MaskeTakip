using MaskeTakip.Entities.Abstract;
using MaskeTakip.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Business.Abstract
{
    public interface IApplicationService<T> where T : class, IEntity, new()
    {
        void ApplyForMAsk(T entity); // Maske başvurusu
        public List<T> GetAll(); // Vatandaşları Listele
        public bool CheckIfPerson(T entity);
    }
}
