using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class CarsValidator : AbstractValidator<Cars>
    {
        public CarsValidator()
        {
            RuleFor(p => p.CarsId).NotEmpty().WithMessage("Vagon Numarası boş olamaz.");
            RuleFor(p => p.CarsName).NotEmpty().WithMessage("Vagon Adı boş olamaz.");
            RuleFor(p => p.CarsCapacity).NotEmpty().WithMessage("Yolcu kapasitesi boş olamaz.");
            RuleFor(p => p.NumberOfTicketsPurchased).NotEmpty().WithMessage("Satılan bilet sayısı boş olamaz.");

        }
    }
}
