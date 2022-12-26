using System.ComponentModel.DataAnnotations;

namespace TravelsalCore.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lutfen adınızı giriniz!")]
		public string Name { get; set; }

        [Required(ErrorMessage = "Lutfen soyadınızı giriniz!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lutfen kullanıcı adınızı giriniz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lutfen mail adresinizi giriniz!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lutfen şifrenizi giriniz!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lutfen şifrenizi tekrar giriniz!")]
        [Compare("Password", ErrorMessage ="Şifreler aynı değil!")]
        public string ConfirmPassword { get; set; }
    }
}
