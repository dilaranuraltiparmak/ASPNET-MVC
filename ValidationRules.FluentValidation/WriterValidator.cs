using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            //doğrulama kuralları:NotEmpty :Boş olamaz
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkında kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az üç karakter giriniz");
            RuleFor(x => x.WriterSurName).MaximumLength(25).WithMessage("Lütfen 50 karakterden fazla karakter girmeyiniz");

        }
    }
}
