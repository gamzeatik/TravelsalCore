using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Username cannot be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Confirmation password cannot be empty");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Username must be at least 5 characters long.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Passwords do not match.");
        }
    }
}
