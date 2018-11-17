using FreeSchool.Application.Interfaces;
using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Interfaces.Services;

namespace FreeSchool.Application
{
    public class StudentAppService : BaseAppService<Student>, IStudentAppService
    {
        private readonly IStudentService _service;
        private readonly IPersonService _personService;
        public StudentAppService(IStudentService service, IPersonService personService) : base(service)
        {
            _service = service;
            _personService = personService;
        }

        public bool Add(Student student)
        {
            Person person = new Person();
            person.Name = student.Person.Name;
            person.IdentificationDocument = student.Person.IdentificationDocument;
            person.BirthDate = student.Person.BirthDate;
            _personService.Add(person);
            student.PersonId = person.Id;
            student.TypeStudentId = student.TypeStudentId;
            _service.Add(student);
            return true;
        }
    }
}
