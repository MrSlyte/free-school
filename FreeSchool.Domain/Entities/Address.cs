using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TypeAddressId { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }

        public virtual Person Person { get; set; }
        public virtual TypeAddress TypeAddress { get; set; }
    }
}
