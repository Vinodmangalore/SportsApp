﻿using Microsoft.AdventureWorks.Data.Services;
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Microsoft.AdventureWorks.Data.Repository
{
    public abstract class Repository<C, T> : IRepository<T> where T : class where C : DbContext, new ()
    {

        private C _entities = new C();

        public C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
