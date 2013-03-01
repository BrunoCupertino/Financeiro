using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.Contract;
using Base.Server.Util;
using System.Reflection;
using Base.Server.Attributes;

namespace Base.Server.DataValidation
{
    public abstract class DataValidations<DO, DF> : ICrud<DO, DF>
        where DO : class, new()
        where DF : class, new()
    {
        public virtual DO Save(DO entity)
        {
            if (entity == null)
            {
                throw new DataValidationException("Não é possível salvar uma entidade nula.");
            }

            this.ValidateDataObjectSave(entity);

            return null;
        }

        public virtual List<DO> Save(List<DO> entities)
        {
            foreach (DO entity in entities)
            {
                this.Save(entity);
            }

            return null;
        }

        public virtual void Delete(DO entity)
        {
            if (entity == null)
            {
                throw new DataValidationException("Não é possivel deletar uma entidade nula.");
            }

            this.ValidateDataObjectDelete(entity);
        }

        public virtual void Delete(List<DO> entities)
        {
            foreach (DO entity in entities)
            {
                this.Delete(entity);
            }
        }

        public virtual DO GetEntity(DF filter)
        {
            if (filter == null)
            {
                throw new DataValidationException("O filtro não pode ser nulo.");
            }

            this.ValidateDataFilterGetEntity(filter);

            return null;
        }

        public virtual List<DO> GetAll(DF filter)
        {
            if (filter == null)
            {
                throw new DataValidationException("O filtro não pode ser nulo.");
            }

            this.ValidateDataFilterGetAll(filter);

            return null;
        }

        protected virtual void ValidateDataObjectSave(DO entity)
        {
            foreach (PropertyInfo prop in Utils.GetPropertiesToTytpe<DO>())
            {
                foreach (IDataValidationAttribute atrribute in prop.GetCustomAttributes(typeof(IDataValidationAttribute), true))
                {
                    if (!atrribute.Validate(prop.GetValue(entity, null)))
                    {
                        if (string.IsNullOrWhiteSpace(atrribute.ErrorMessage))
                        {
                            atrribute.ErrorMessage = string.Format("O preenchimento do {0} é obrigatório.", prop.Name);
                        }

                        throw new DataValidationException(atrribute.ErrorMessage);
                    }
                }
            }
        }

        protected virtual void ValidateDataObjectDelete(DO entity)
        {
        }

        protected virtual void ValidateDataFilterGetEntity(DF filter)
        {
        }

        protected virtual void ValidateDataFilterGetAll(DF filter)
        {
        }
    }
}
