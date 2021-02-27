﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        { // Bütün projelerde kullanacağımız için core katmanında tanımladık. Tool haline getirdik.
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);// sonuç geçerli değilse hata fırlat.

            }

        }
    }
}
