using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces;
using FreeSchool.Domain.Interfaces.Repositories;

namespace FreeSchool.Infra.Data.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {

    }
}
