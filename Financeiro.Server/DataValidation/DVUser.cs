using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.DataValidation;
using Base.Server.Model;
using Financeiro.Server.DataFilter;

namespace Financeiro.Server.DataValidation
{
    public class DVUser : DataValidations<User, DFUser>
    {
        public void LogOn(DFUser filter)
        {
            if (String.IsNullOrWhiteSpace(filter.Email))
            {
                throw new DataValidationException("O preenchimento do Email é obrigatório.");
            }

            if (String.IsNullOrWhiteSpace(filter.Password))
            {
                throw new DataValidationException("O preenchimento da Senha é obrigatório.");
            }
        }

        public void LogOn(User entity)
        {
            if (entity == null)
            {
                throw new DataValidationException("Usuário e/ou senha inválido.");
            }
        }

        public void CheckContainsEmail(List<User> users)
        {
            if (users.Count > 0)
            {
                throw new DataValidationException("Já existe um usuário com o mesmo nome.");
            }
        }

        protected override void ValidateDataObjectSave(User entity)
        {
            base.ValidateDataObjectSave(entity);

            if (string.IsNullOrWhiteSpace(entity.FirstName))
            {
                throw new DataValidationException("O preenchimento do Nome é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(entity.LastName))
            {
                throw new DataValidationException("O preenchimento do Sobrenome é obrigatório.");
            }

            if (string.IsNullOrWhiteSpace(entity.Email))
            {
                throw new DataValidationException("O preenchimento do Email é obrigatório.");
            }

            if(string.IsNullOrWhiteSpace(entity.Password))
            {
                throw new DataValidationException("O preenchimento da Senha é obrigatório.");
            }
        }
    }
}
