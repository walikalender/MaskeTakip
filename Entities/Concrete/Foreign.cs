using MaskeTakip.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip.Entities.Concrete
{
    public class Foreign : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ForeignIdentityNumber { get; set; }
    }
}
