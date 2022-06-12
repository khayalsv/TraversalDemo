﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator <About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Bos ola bilmez");
            RuleFor(x => x.Description1).Length(2,60).WithMessage("Uzunlugu duzgun qeyd edin");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Bos ola bilmez");

        }
    }
}
