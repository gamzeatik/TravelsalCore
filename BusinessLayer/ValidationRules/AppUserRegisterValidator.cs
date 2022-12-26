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
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş bırakılamaz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş bırakılamaz");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail boş bırakılamaz");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş bırakılamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre boş bırakılamaz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar boş bırakılamaz");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı en az 5 karakter olmalı.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor.");
        }
    }
}
