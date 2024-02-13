﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY.PersonelTakip.DAL.Abstract;
using YY.PersonelTakip.Entity.Abstract;

namespace YY.PersonelTakip.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private DbContext DbContext { get; set; }
        private DbSet<T> _dbset;
        public GenericRepository(DbContext context)
        {
            DbContext = context;
            _dbset = DbContext.Set<T>();

        }
        public void Add(T entity)
        {
            _dbset.Add(entity);
            DbContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            _dbset.Remove(entity);
            DbContext.SaveChanges();
        }
        public List<T> GetAll() => _dbset.ToList();
        
        public IQueryable<T> GetQueryable() => _dbset.AsQueryable<T>();

        public void Update(T entity)
        {
            DbContext.SaveChanges();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
