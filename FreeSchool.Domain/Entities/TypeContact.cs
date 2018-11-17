using FreeSchool.Domain.Interfaces;

namespace FreeSchool.Domain.Entities
{
    public class TypeContact : IEntityEnum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
