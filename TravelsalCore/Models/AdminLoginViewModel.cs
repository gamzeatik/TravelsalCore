using System.ComponentModel.DataAnnotations;

namespace TravelsalCore.Models
{
    public class AdminLoginViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }
    }
}
