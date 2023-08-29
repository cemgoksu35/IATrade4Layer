using System;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün Adını boş geçemezsiniz.");
			RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır.");
			RuleFor(x => x.Stock).NotEmpty().WithMessage("Ürün adedi boş geçilemez.");
			RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez.");
		}
	}
}

