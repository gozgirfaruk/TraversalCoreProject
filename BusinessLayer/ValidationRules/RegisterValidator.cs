using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RegisterValidator : AbstractValidator<AppUser>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Boş Geçilemez").MinimumLength(3).WithMessage("En az 3 Karakterden oluşmalıdır.").MaximumLength(15).WithMessage("En fazla 15 karakterden meydana gelmelidir.");
          
        }

    }
}
