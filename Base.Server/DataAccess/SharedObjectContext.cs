using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.Model;

namespace Base.Server.DataAccess
{
    public sealed class SharedObjectContext
    {
        private readonly FinanceiroEntities context;

        #region Singleton Pattern

        private static readonly SharedObjectContext instance = new SharedObjectContext();

        private SharedObjectContext() 
        {
            context = new FinanceiroEntities();
        }

        public static SharedObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        #endregion

        public FinanceiroEntities Context
        {
            get
            {
                return context;
            }
        }
    }
}
