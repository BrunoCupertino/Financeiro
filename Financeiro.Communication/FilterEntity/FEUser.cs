using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro.Communication.FilterEntity
{
    public class FEUser
    {
        public virtual int? Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Password { get; set; }

        public virtual int? State { get; set; }
    }
}
