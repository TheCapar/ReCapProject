using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Kolor>
    {
        public ColorValidator()
        {
            RuleFor(c => c.KolorName).NotEmpty();
            RuleFor(c => c.KolorName).MinimumLength(2);
        }
    }
}
