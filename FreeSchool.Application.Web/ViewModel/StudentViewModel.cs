using FreeSchool.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeSchool.Application.Web.ViewModel
{
    public class StudentViewModel
    {
        [Key]
        public int Id { get; set; }
        public PersonViewModel Person { get; set; }
        public EnumTypeStudent TypeStudent { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DisplayName("Register Date")]
        public DateTime RegisterDate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? UpdateDate { get; set; }
        [MaxLength(20)]
        [DisplayName("Identification Number")]
        public string IdentificationNumberSchool { get; set; }
        public StatusStudentViewModel StatusStudent { get; set; }
        [ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? DeleteDate { get; set; }

        public List<SelectListItem> TypeStudentList { get; set; }

    }
}