using FreeSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public int TypeContactId { get; set; }
        public int PersonId { get; set; }
        public string Value { get; set; }
        public bool IsOnline { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public virtual TypeContact TypeContact { get; set; }
        public virtual Person Person { get; set; }
    }
}
