using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FreeSchool.Application.Web.ViewModel
{
    public class TypeStudentViewModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
    }
}