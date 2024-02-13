using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.DAL.Abstract
{
    public interface IRepository<T> where T : class, IEntity
    {
        //CRUD islemler için sabit metotlar
        void Add(T entity); // Insert into table values()
        void Delete(T entity); // Delete from tabel where id=@id
        void Update(T entity); // Update table set column=@columnValue;

        List<T> GetAll(); // ToList(); select * from T(Products)

        T Get(int id); // GetById(int id); select * from T(Products) where id=@id;
    }
}
