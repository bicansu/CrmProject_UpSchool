using CrmUpSchool.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmUpSchool.BusinessLayer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel adını boş geçemezsiniz!");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel soyadını boş geçemezsiniz!");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz!");
            RuleFor(x => x.EmployeeName).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz!");

        }
    }
}
