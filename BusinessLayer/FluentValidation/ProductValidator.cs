﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını boş geçemezsiniz.");
            RuleFor(x => x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır.");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Stok sayısı boş geçilemez");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Fiyat sayısı boş geçilemez");

        }
    }
}
