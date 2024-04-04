using Microsoft.AspNetCore.Identity;

namespace TravelsalCore.Models
{
	public class CustomIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError() { Code = "PasswordTooShort", Description = $"Password must be at least {length} characters long." };
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError() { Code = "PasswordRequiresUpper", Description = $"Password must contain at least 1 uppercase letter (A-Z)." };
		}

		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError() { Code = "PasswordRequiresLower", Description = $"Password must contain at least 1 lowercase letter (a-z)." };
		}

		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError() { Code = "PasswordRequiresNonAlphanumeric", Description = $"Password must contain at least 1 symbol (*,.;+/-)." };
		}
	}

}
