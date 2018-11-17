using FreeSchool.Domain.Interfaces;

namespace FreeSchool.Domain.Entities
{
    public class TypeApprobationNote
    {
        public int Id { get; set; }
        public string ApprobationNoteSchool { get; set; }
        public int ApprobationNoteSystem { get; set; }
        public bool IsDeleted { get; set; }
    }
}
