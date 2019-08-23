using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomNameValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if(value.ToString().Contains("Giomar"))
                {
                    return ValidationResult.Success;
                }
                else
                {

                    return new ValidationResult("Não deu certo");
                }


            }
            return new ValidationResult("O Campo:" +
                validationContext.DisplayName + "é um campo obrigatorio.");


        }

    }
}