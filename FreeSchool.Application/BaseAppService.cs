using FreeSchool.Application.Interfaces;
using FreeSchool.Domain.Interfaces.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Application
{
    public class BaseAppService<TEntity> : IDisposable, IBaseAppService<TEntity> where TEntity : class
    {
        private readonly IBaseService<TEntity> _service;
        public BaseAppService(IBaseService<TEntity> service)
        {
            _service = service;
        }
        public void Add(TEntity obj)
        {
            _service.Add(obj);
        }

        public TEntity Get(int Id)
        {
            return _service.Get(Id);
        }

        public IEnumerable<TEntity> List()
        {
            return _service.List();
        }

        public void Update(TEntity obj)
        {
            _service.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _service.Remove(obj);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
