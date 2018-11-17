using FreeSchool.Domain.Interfaces;
using System;

namespace FreeSchool.Domain.Entities
{
    public class Student : IEntity, IDelEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TypeStudentId { get; set; }
        public DateTime? RegisterDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string IdentificationNumberSchool { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Person Person { get; set; }
        public virtual TypeStudent TypeSudent { get; set; }

        public bool IsValid()
        {
            return true;
        }
    }
}
