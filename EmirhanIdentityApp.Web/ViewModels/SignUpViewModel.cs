using System.ComponentModel.DataAnnotations;

namespace EmirhanIdentityApp.Web.ViewModels
{
    public class SignUpViewModel
    {
        public SignUpViewModel()
        {

        }
        public SignUpViewModel(string userName,string email,string phone, string password)
        { 
            UserName = userName;
            Email = email;
            Phone = phone;
            Password = password;
        }
        [Required(ErrorMessage ="Kullanıcı Adı boş bırakalamaz")]
        [Display(Name ="Kullanıcı Adı : ")]
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="Email formatı doğru giriniz.")]
        [Required(ErrorMessage = "Email boş bırakalamaz")]
        [Display(Name = "Email : ")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Telefon boş bırakalamaz")]
        [Display(Name = "Telefon  : ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = " Şifre boş bırakalamaz")]
        [Display(Name = " Şifre : ")]
        public string Password { get; set; }


        [Compare(nameof(Password),ErrorMessage ="Şifreler birbirleriyle uyuşmuyor!")]
        [Required(ErrorMessage = " Şifre boş bırakalamaz")]
        [Display(Name = " Şifre Tekrar : ")]
        public string PasswordConfirm { get; set; }
    }
}
