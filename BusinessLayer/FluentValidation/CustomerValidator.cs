﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>

    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("İsim boş geçilemez");
        }
    }
}
