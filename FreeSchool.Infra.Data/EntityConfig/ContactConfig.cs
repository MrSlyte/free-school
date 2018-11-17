using FreeSchool.Domain.Entities;
using FreeSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Infra.Data.EntityConfig
{
    public class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            ToTable("Contact");

            HasKey<int>(k => k.Id);
            Property(x => x.Id).HasColumnName("Id");
        }
    }
}
