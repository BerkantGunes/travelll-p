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
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Announcement Title can not be blank");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Announcement Content can not be blank");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Title must be minimum 5 characters");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Content must be minimum 5 characters");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Title must be maximum 50 characters");
            RuleFor(x => x.Content).MaximumLength(400).WithMessage("Content must be maximum 400 characters");
        }
    }
}
