using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.UILayer.Models
{
    public class RoleViewMoldel
    {
        [Required(ErrorMessage ="Lütfen rol adını boş geçmeyin")]
        public string RoleName { get; set; }
    }
}
