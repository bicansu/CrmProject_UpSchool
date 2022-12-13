using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator: AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanını boş geçemezsiniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("İçerik alanını boş geçemezsiniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en z 5 karakter veri girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapınız");
        }
    }
}
