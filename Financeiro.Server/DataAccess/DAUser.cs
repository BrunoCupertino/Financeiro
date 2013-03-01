using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base.Server.DataAccess;
using Financeiro.Server.DataFilter;
using Base.Server.Model;

namespace Financeiro.Server.DataAccess
{
    public class DAUser : DataToAccess<User, DFUser>
    {
        public DAUser() :
            base()
        {
        }

        public override User GetEntity(DFUser filter)
        {
            var query = from u in this.GetTable()
                        where (u.Id == filter.Id || filter.Id == null)
                        select u;

            return query.SingleOrDefault();
        }

        public override List<User> GetAll(DFUser filter)
        {
            var query = from u in this.GetTable()
                        where (u.Id.Equals(filter.Id.Value) || filter.Id == null)
                              && (u.FirstName.Contains(filter.FirstName) || filter.FirstName == null)
                              && (u.LastName.Contains(filter.LastName) || filter.LastName == null)
                              && (u.Password.Contains(filter.Password) || filter.Password == null)
                              && (u.Email.Contains(filter.Email) || filter.Email == null)
                              && (u.State.Equals(filter.State) || filter.State == null)
                        orderby u.FirstName, u.LastName
                        select u;

            return query.ToList();
        }

        public User LogOn(DFUser filter)
        {
            var query = from u in this.GetTable()
                        where (u.Email == filter.Email || filter.Email == null)
                              && (u.Password == filter.Password || filter.Password == null)
                        select u;

            return query.SingleOrDefault();
        }
    }
}
