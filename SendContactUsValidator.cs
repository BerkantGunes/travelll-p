using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail field can not be null!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field can not be null!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Subject field can not be null!");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Message field can not be null!");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Subject must be at least 5 characters!");
            RuleFor(x => x.Subject).MinimumLength(150).WithMessage("Subject must be maximum 150 characters!");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("Mail must be at least 5 characters!");
            RuleFor(x => x.Mail).MinimumLength(150).WithMessage("Mail must be maximum 150 characters!");
        }
    }
}
