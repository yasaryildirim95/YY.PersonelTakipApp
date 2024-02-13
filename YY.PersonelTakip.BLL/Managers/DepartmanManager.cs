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
    public class DepartmanManager : GenericManager<Departman>, IDepartmanService
    {
        public DepartmanManager(IRepository<Departman> repository) : base(repository)
        {
        }
    }
}
