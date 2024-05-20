using DTOLayer.DTOs.Announcement;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Başlık Giriniz").MaximumLength(30).WithMessage("Başlık 30 karakterden Az olacak şekilde yazınız").MinimumLength(5).WithMessage("Başlık 5 karakterden daha uzun olmalıdır.");
            RuleFor(x => x.Body).NotEmpty().WithMessage("İçerik boş geçilemez").MinimumLength(5).WithMessage("minimum 6 karakter olmalıdır");
        }
    }
}
