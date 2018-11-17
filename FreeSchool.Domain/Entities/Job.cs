using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TaskId { get; set; }
        public bool IsDeleted { get; set; }
        public int FrequencyId { get; set; }
        public bool RepeatForever { get; set; }
        public DateTime? EndJobDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
