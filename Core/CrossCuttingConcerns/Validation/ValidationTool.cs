using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    //Static bir sınıfın metodlarınında static olması gerekir.
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var contetxt = new ValidationContext<object>(entity);
            var result = validator.Validate(contetxt);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
