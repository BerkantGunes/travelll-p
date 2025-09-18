using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(x => x.Content).NotEmpty().WithMessage("Content can not be blank!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can not be blank!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Title must be minimum 5 characters");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Content must be minimum 5 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title must be maximum 50 characters");
            RuleFor(x => x.Content).MaximumLength(400).WithMessage("Content must be maximum 400 characters");
        }
    }
}
