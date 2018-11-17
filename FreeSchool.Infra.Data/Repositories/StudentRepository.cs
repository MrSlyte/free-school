using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces.Repositories;

namespace FreeSchool.Infra.Data.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {

    }
}
