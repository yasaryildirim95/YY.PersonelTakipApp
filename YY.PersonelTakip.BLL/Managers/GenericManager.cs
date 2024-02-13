using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.BLL.Services;
using YY.PersonelTakip.DAL.Abstract;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.BLL.Managers
{
    public abstract class GenericManager<T>:IGenericService<T> where T : class,IEntity
    {
        private IRepository<T> _repository;

        public GenericManager(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Add(T entity)
        {
            _repository.Add(entity);

        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

    }
}
