using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreeSchool.Application.Interfaces
{
    public interface IBaseAppService<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity Get(int Id);
        IEnumerable<TEntity> List();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
