﻿using FreeSchool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeSchool.Domain.Entities
{
    public class School : IEntity, IDelEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentificationDocument { get; set; }
        public string CompanyName { get; set; }
        public bool IsOnline { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
