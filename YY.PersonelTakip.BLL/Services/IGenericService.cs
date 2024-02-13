using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.BLL.Services
{
    public interface IGenericService<T> where T : class,IEntity
    {
        T Get(int id);
        void Update(T entity);
        void Delete(T entity);
        void Add(T entity);

        List<T> GetAll();

    }
}
