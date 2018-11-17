using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Enums
{
    public enum EnumTypeStudent
    {
        [Description("None")]
        None = 0,
        [Description("Active")]
        Active = 1,
        [Description("Inative")]
        Inative = 2
    }
}
