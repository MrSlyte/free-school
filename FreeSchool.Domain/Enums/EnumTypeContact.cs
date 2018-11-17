using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Enums
{
    public enum EnumTypeContact
    {
        [Description("Finance Responsible")]
        Finance = 0,

        [Description("Commercial Responsible")]
        Comercial = 1,

        [Description("Legal Responsible")]
        Legal = 2
    }
}
