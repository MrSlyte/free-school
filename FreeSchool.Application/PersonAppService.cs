using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces.Services;

namespace FreeSchool.Application
{
    public class PersonAppService : BaseAppService<Person>, IPersonAppService
    {
        private readonly IPersonService _service;
        public PersonAppService(IPersonService service)
            : base(service)
        {
            _service = service;
        }
    }
}
