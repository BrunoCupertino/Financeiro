using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.Contract;
using Base.Server.DataValidation;
using Base.Server.DataAccess;

namespace Base.Server.DataController
{
    public abstract class DataControllers<DO, DF, DV, DA> : ICrud<DO, DF>
        where DO : class, new()
        where DF : class, new()
        where DV : DataValidations<DO, DF>, new()
        where DA : DataToAccess<DO, DF>, new()
    {
        public DataControllers()
        {
            this.DataValidation = new DV();
            this.DataToAccess = new DA();
        }

        protected DV DataValidation { get; set; }
        protected DA DataToAccess { get; set; }

        public virtual DO Save(DO entity)
        {
            DataValidation.Save(entity);
            return DataToAccess.Save(entity);
        }

        public virtual List<DO> Save(List<DO> entities)
        {
            DataValidation.Save(entities);
            return DataToAccess.Save(entities);
        }

        public virtual void Delete(DO entity)
        {
            DataValidation.Delete(entity);
            DataToAccess.Delete(entity);
        }

        public virtual void Delete(List<DO> entities)
        {
            DataValidation.Delete(entities);
            DataToAccess.Delete(entities);
        }

        public virtual DO GetEntity(DF filter)
        {
            DataValidation.GetEntity(filter);
            return DataToAccess.GetEntity(filter);
        }

        public virtual List<DO> GetAll(DF filter)
        {
            DataValidation.GetAll(filter);
            return DataToAccess.GetAll(filter);
        }
    }
}
