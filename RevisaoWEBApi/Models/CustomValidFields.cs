using RevisaoWEBApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace RevisaoWEBApi.Models
{
    public class CustomValidFields : ValidationAttribute
    {
        ContextDB dB = new ContextDB();

        private ValidFields typeField;

        public CustomValidFields(ValidFields type)
        {
            typeField = type;

        }


        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            if (value != null)
            {
                switch (typeField)
                {
                    case ValidFields.ValidaLogin:
                        {
                            Usuario user = dB.usuarios.FirstOrDefault(x => x.Login == value.ToString());

                            if (user == null)
                            {
                                return ValidarLogin(value, validationContext.DisplayName);

                            }
                            else
                            {
                                return new ValidationResult("O login informado já existe.");
                            }
                        }

                    case ValidFields.ValidaEmail:
                        { return ValidarEmail(value, validationContext.DisplayName);}

                    case ValidFields.ValidaSenha:
                        { return ValidarSenha(value, validationContext.DisplayName);}

                    case ValidFields.ValidaNome:
                        { return ValidarNome(value, validationContext.DisplayName);}
                    default:
                        break;
                }
            }

            return new ValidationResult($"O campo{validationContext.DisplayName}é obrigatorio");
        }
        private ValidationResult ValidarEmail(object value,string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo{displayField} é invalido");
          
        }
        private ValidationResult ValidarSenha(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^([a-zA-Z0-9]{8,15})$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo{displayField} é invalido");

        }
        private ValidationResult ValidarNome(object value, string displayField)
        {
            var result = Regex.IsMatch(value.ToString(), @"^[A-ZÀ-Ÿ][A-zÀ-ÿ']+\s([A-zÀ-ÿ']\s?)*[A-ZÀ-Ÿ][A-zÀ-ÿ']+$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo{displayField} é invalido");

        }
        private ValidationResult ValidarLogin(object value, string displayField)
        {

            var result = Regex.IsMatch(value.ToString(), @"^(?![_ -])(?:(?![_ -]{2})[\w -]){8,16}(?<![_ -])$");
            if (result)
                return ValidationResult.Success;

            return new ValidationResult($"O campo{displayField} é invalido");

        }
    }
}