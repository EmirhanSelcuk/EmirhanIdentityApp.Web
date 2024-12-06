﻿using System.ComponentModel.DataAnnotations;

namespace EmirhanIdentityApp.Web.ViewModels
{
    public class PasswordChangeViewModel
    {

        [DataType(DataType.Password)]
        [Required(ErrorMessage = " Şifre boş bırakalamaz")]
        [Display(Name = " Yeni Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]
        public string PasswordOld { get; set; } = null!;

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Yeni Şifre alanı boş bırakalamaz")]
        [Display(Name = " Yeni Şifre : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]

        public string PasswordNew { get; set; } = null!;

        [DataType(DataType.Password)]
        [Compare(nameof(PasswordNew), ErrorMessage = "Şifreler birbirleriyle uyuşmuyor!")]
        [Required(ErrorMessage = " Yeni şifre  alanı boş bırakalamaz")]
        [Display(Name = "Yeni Şifre Tekrar : ")]
        [MinLength(6, ErrorMessage = "Şifreniz en az 6 karakter olabilir.")]

        public string PasswordConfirm { get; set; } = null!;
    }
}
