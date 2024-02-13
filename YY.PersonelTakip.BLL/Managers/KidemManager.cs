using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.BLL.Services;
using YY.PersonelTakip.DAL.Abstract;
using YY.PersonelTakip.Entity.Entities;

namespace YY.PersonelTakip.BLL.Managers
{
    public class KidemManager : GenericManager<Kidem>, IKidemService
    {
        public KidemManager(IRepository<Kidem> repository) : base(repository)
        {
        }
    }
}
