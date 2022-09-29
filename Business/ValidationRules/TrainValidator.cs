using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class TrainValidator : AbstractValidator<Trains>
    {
        public TrainValidator()
        {
            RuleFor(p => p.TrainId).NotEmpty().WithMessage("Tren ID'si boş olamaz.");
            RuleFor(p => p.TrainName).NotEmpty().WithMessage("Tren Adı Boş Olamaz.");
            RuleFor(p => p.TrainName).MaximumLength(50).WithMessage("Tren Adı Maksimum 50 karakterden oluşmalıdır.");
                    }
    }
}
