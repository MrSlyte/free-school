using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeSchool.Application.Web.ViewModel
{
    public class PersonViewModel
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(500)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [MaxLength(100)]
        [DisplayName("Identification Document")]
        public string IdentificationDocument { get; set; }

        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdateDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DeleteDate { get; set; }
    }
}