using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterViewModel
    {
        [Required (ErrorMessage ="Lütfen isim  giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyisim  giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen cinsiyet  giriniz")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı giriniz")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen mailinizi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare ("Password",ErrorMessage ="Lütfen şifrelerin eşleştiğinden emin olun")]
        public string ConfirmPassword { get; set; }



    }
}
