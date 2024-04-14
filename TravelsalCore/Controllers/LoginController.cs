using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using TravelsalCore.Models;

namespace TravelsalCore.Controllers
{        
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
			// Check for duplicates
			var existingUserByUsername = await _userManager.FindByNameAsync(p.Username);
			var existingUserByEmail = await _userManager.FindByEmailAsync(p.Mail);

			if (existingUserByUsername != null)
			{
				ModelState.AddModelError("Username", "This username is already in use.");
			}

			if (existingUserByEmail != null)
			{
				ModelState.AddModelError("Mail", "This email address is already in use.");
			}

			if (p.Password != p.ConfirmPassword)
			{
				ModelState.AddModelError("", "Password and password confirmation do not match.");
			}

			// If all validations pass, create the new user
			if (ModelState.IsValid)
			{
				AppUser appUser = new AppUser()
				{
					Name = p.Name,
					Surname = p.Surname,
					Email = p.Mail,
					UserName = p.Username
				};

                var result = await _userManager.CreateAsync(appUser, p.Password);
				
				if (result.Succeeded)
				{
                    await _userManager.AddToRoleAsync(appUser, "Member");
                    return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError("", error.Description);
					}
				}
			}

			return View(p);
		}

		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username,p.password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile",new {area="Member"});
                }
                else
                {
                    return RedirectToAction("SingIn", "Login");
                }
            }
            return View();
        }
    }
}
