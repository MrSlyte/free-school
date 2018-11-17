using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FreeSchool.Application.Web.ViewModel
{
    public class StatusStudentViewModel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Status")]
        public string Name { get; set; }
    }
}
