using System;
using System.ServiceProcess;
using System.Runtime.Serialization;

namespace OpenAFSClientManager
{
    [Serializable]
    public class UnhandledStateException : Exception
    {
        protected UnhandledStateException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        
        public UnhandledStateException()
            : base()
        {
        }
        
        public UnhandledStateException(ServiceControllerStatus status)
            : base(Enum.GetName(typeof(ServiceControllerStatus), status))
        {
        }

        public UnhandledStateException(string message)
            : base(message)
        {
        }

        public UnhandledStateException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
