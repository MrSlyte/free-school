using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RemaningTime { get; set; }

    }
}
