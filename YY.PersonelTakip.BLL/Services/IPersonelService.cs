using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.BLL.Services
{
    public interface IPersonelService : IGenericService<Personel>
    {
        public Personel Get(string tc);
    }
}
