using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Please do not leave the title empty");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Please do not leave the announcement content empty");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Please enter at least 5 characters of data");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Please enter at least 20 characters of data");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Please enter up to 50 characters of data");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("Please enter up to 500 characters of data");
        }

    }
}
