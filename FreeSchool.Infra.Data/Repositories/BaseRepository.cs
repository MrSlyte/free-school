using FreeSchool.Domain.Interfaces.Repositories;
using FreeSchool.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FreeSchool.Infra.Data.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected FreeSchoolContext context = new FreeSchoolContext();
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Add(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();
        }

        public void AddCollection(IEnumerable<TEntity> obj)
        {
            context.Set<TEntity>().AddRange(obj);
        }

        public TEntity Get(int Id)
        {
            return context.Set<TEntity>().Find(Id);
        }

        public TEntity GetByField(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).First();
        }

        public IEnumerable<TEntity> List()
        {
            return context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> ListByField(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public void Update(TEntity obj)
        {
            context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            context.SaveChanges();
        }
    }
}
