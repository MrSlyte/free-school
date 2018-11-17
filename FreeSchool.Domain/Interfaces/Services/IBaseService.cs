using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreeSchool.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int Id);
        TEntity GetByField(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> List();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
