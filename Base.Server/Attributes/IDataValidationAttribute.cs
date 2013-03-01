using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.Server.Attributes
{
    public interface IDataValidationAttribute
    {
        string ErrorMessage { get; set; }
        bool Validate(object currrentValue);
    }
}
