using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
  public  class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            //doğrulama kuralları:NotEmpty :Boş olamaz
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az üç karakter giriniz");
            RuleFor(x => x.CategoryName).MaximumLength(25).WithMessage("Lütfen 25 karakterden fazla karakter girmeyiniz");
         
        }

    }
}
