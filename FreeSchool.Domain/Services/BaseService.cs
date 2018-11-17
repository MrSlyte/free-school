using FreeSchool.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using FreeSchool.Domain.Interfaces.Repositories;

namespace FreeSchool.Domain.Services
{
    public class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repo;
        public BaseService(IBaseRepository<TEntity> repo)
        {
            _repo = repo;
        }
        public void Add(TEntity obj)
        {
            _repo.Add(obj);
        }

        public TEntity Get(int Id)
        {
            return _repo.Get(Id);
        }

        public TEntity GetByField(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return _repo.GetByField(predicate);
        }

        public IEnumerable<TEntity> List()
        {
            return _repo.List();
        }

        public void Update(TEntity obj)
        {
            _repo.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _repo.Remove(obj);
        }

        public void Dispose()
        {
            _repo.Dispose();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
