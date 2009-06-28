using System;
using System.ServiceProcess;

namespace OpenAFS_Client_Manager
{
    class UnhandledStateException : Exception
    {
        public UnhandledStateException(ServiceControllerStatus status)
            : base(Enum.GetName(typeof(ServiceControllerStatus), status))
        {
        }
    }
}
