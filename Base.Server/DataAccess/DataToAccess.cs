using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using Base.Server.Model;
using Base.Server.Util;
using Base.Server.Contract;
using System.Data;

namespace Base.Server.DataAccess
{
    public abstract class DataToAccess<DO, DF> : ICrud<DO, DF>
        where DO : class, new()
        where DF : class, new()
    {
        public DataToAccess()
        {
            this.ObjectContext = SharedObjectContext.Instance.Context;
        }

        protected FinanceiroEntities ObjectContext { get; private set; }

        protected ObjectSet<DO> GetTable()
        {
            ObjectSet<DO> os = this.ObjectContext.CreateObjectSet<DO>();
            return os;
        }

        protected bool TryGetStateEntity(DO entity, out EntityState state)
        {            
            ObjectStateEntry stateEntry;
            state = 0;

            bool result = this.ObjectContext.ObjectStateManager.TryGetObjectStateEntry(entity, out stateEntry);

            if (result)
            {
                state = stateEntry.State;
            }

            return result;
        }

        public virtual DO Save(DO entity)
        {
            EntitySetNameAttribute attribute = Utils.GetAttribute<EntitySetNameAttribute>(typeof(DO));
            EntityState state;

            if (!this.TryGetStateEntity(entity, out state))
            {
                this.ObjectContext.AddObject(attribute.EntitySetName, entity);
            }

            this.ObjectContext.SaveChanges();

            return entity;
        }

        public virtual List<DO> Save(List<DO> entities)
        {
            foreach (DO entity in entities)
            {
                this.Save(entity);
            }

            return entities;
        }

        public virtual void Delete(DO entity)
        {
            this.ObjectContext.DeleteObject(entity);
            this.ObjectContext.SaveChanges();
        }

        public virtual void Delete(List<DO> entities)
        {
            foreach (DO entity in entities)
            {
                this.Delete(entity);
            }
        }

        public abstract DO GetEntity(DF filter);

        public abstract List<DO> GetAll(DF filter);
    }
}
