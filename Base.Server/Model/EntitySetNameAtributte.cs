using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Server.Model
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EntitySetNameAttribute : Attribute
    {
        public string EntitySetName { get; set; }
    }
}
