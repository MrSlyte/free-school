using FreeSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Worker : IEntity, IDelEntity
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int SchoolId { get; set; }
        public int JobRoleId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime ContractBeginDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
    }
}
