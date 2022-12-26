using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description can not be empty!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Description must minimum 50 characters!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Image can not be empty!");
            RuleFor(x => x.Description).MaximumLength(1000).WithMessage("Description must maximum 1000 characters!");
        }
    }
}
