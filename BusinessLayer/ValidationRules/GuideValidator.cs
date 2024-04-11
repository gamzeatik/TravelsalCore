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
            RuleFor(x => x.Name).NotEmpty().WithMessage("Guide name cannot be empty.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Guide description cannot be empty.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Guide image cannot be empty.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter no more than 30 characters.");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Please enter at least 10 characters.");
        }
    }
}
