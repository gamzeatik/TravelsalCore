using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rehber adı boş olamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Rehber açıklaması boş olamaz.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Rehber fotoğrafı boş olamaz.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden daha az giriş yapın.");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Lütfen 10 karakterden daha fazla giriş yapın.");
        }
    }
}
