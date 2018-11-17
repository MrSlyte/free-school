using FreeSchool.Application.Interfaces;
using FreeSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreeSchool.Application
{
    public interface IPersonAppService : IBaseAppService<Person>
    {
    }
}
