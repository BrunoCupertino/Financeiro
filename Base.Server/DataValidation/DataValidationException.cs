using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Base.Server.DataValidation
{
    public class DataValidationException : Exception
    {
        public DataValidationException()
            : base()
        {
        }

        public DataValidationException(string message)
            : base(message)
        {
        }

        public DataValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public DataValidationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext)
        {
        }
    }
}
