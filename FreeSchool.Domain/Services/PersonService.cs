using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces.Repositories;
using FreeSchool.Domain.Interfaces.Services;

namespace FreeSchool.Domain.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        private readonly IPersonRepository _repo;
        public PersonService(IPersonRepository repo)
            : base(repo)
        {
            _repo = repo;
        }
    }
}
