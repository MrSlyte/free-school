using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Interfaces
{
    interface IDelEntity
    {
        bool IsDeleted { get; set; }
        DateTime? DeleteDate { get; set; }
    }
}
