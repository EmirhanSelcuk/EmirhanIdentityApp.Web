using System.ComponentModel.DataAnnotations;

namespace EmirhanIdentityApp.Web.Areas.Admin.Models
{
    public class RoleUpdateViewModel
    {
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = " Rol isim alanı boş bırakalamaz")]
        [Display(Name = " Rol isim alanı : ")]
        public string Name { get; set; } = null;
    }
}
