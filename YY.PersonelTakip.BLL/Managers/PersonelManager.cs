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
    public class PersonelManager : GenericManager<Personel>,IPersonelService
    {
        private IRepository<Personel> _repository;
        public PersonelManager(IRepository<Personel> repository) : base(repository)
        {
            _repository = repository;
        }

        public Personel Get(string tc)
        {
            return _repository.GetAll().Where(a=>a.Tc.Equals(tc)).FirstOrDefault();
        }



    }
}
