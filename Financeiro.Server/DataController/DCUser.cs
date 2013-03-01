using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Financeiro.Server.DataAccess;
using Financeiro.Server.DataValidation;
using Base.Server.Model;
using Financeiro.Server.DataFilter;
using Base.Server.DataController;
using Base.Server.Session;

namespace Financeiro.Server.DataController
{
    public class DCUser : DataControllers<User, DFUser, DVUser, DAUser>
    {
        public void LogOn(DFUser filter)
        {
            User user = null;
            this.DataValidation.LogOn(filter);
            user = this.DataToAccess.LogOn(filter);
            this.DataValidation.LogOn(user);
            Session.LogOn(user);
        }

        public override User Save(User entity)
        {
            this.DataValidation.Save(entity);
            //List<User> users = DataToAccess.GetAll(new DFUser() { Email = entity.Email });
            //this.DataValidation.CheckContainsEmail(users);
            return DataToAccess.Save(entity);
        }
    }
}
