using FreeSchool.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Application.Interfaces
{
    public interface IStudentAppService : IBaseAppService<Student>
    {
        bool Add(Student student);
    }
}
