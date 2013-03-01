using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Server.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class RequiredDataAttribute : Attribute, IDataValidationAttribute
    {
        public object NullValue { get; set; }
        public string ErrorMessage { get; set; }

        public bool Validate(object currentValue)
        {
            bool result = true;

            if (object.Equals(NullValue, currentValue) || currentValue == null)
            {
                result = false;
            }

            return result;
        }
    }
}
