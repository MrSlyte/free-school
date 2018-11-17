using FreeSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class ItemActivity : IEntity, IDelEntity
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public int ApprobationNoteId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual TypeApprobationNote TypeApprobationNote { get; set; }
    }
}
