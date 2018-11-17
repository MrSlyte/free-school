using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces.Repositories;
using FreeSchool.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Services
{
    public class StudentService : BaseService<Student>, IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo) : base(repo)
        {
            _repo = repo;
        }
    }
}
