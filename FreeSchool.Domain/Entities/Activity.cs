using FreeSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Activity : IEntity, IDelEntity
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public int TypeActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MinimumApprobation { get; set; }
        public bool IsOnline { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Module Module { get; set; }
        public virtual TypeActivity TypeActivity { get; set; }
    }
}
