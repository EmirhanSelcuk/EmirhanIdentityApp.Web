using System.ComponentModel.DataAnnotations;

namespace EmirhanIdentityApp.Web.ViewModels
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakalamaz")]
        [Display(Name = "Kullanıcı Adı : ")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Email formatı doğru giriniz.")]
        [Required(ErrorMessage = "Email boş bırakalamaz")]
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Telefon boş bırakalamaz")]
        [Display(Name = "Telefon  : ")]
        public string Phone { get; set; } = null;

        [Display(Name = "Doğum Tarihi   : ")]
        public string? BirthDate { get; set; }

        [Display(Name = " Şehir  : ")]
        public string? City { get; set; }

        [Display(Name = " Profil Resmi  : ")]
        public IFormFile? Picture { get; set; }

        [Display(Name = " Cinsiyet  : ")]
        public byte? Gender { get; set; }







    }
}
