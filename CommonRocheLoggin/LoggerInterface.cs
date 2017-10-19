using System;
using System.Collections.Generic;
using System.Text;

namespace CommonExampleLoggin
{
    interface LoggerInterface
    {
        /// <summary>
        /// Logs message into log file.
        /// Creates log file if it not exists.
        /// </summary>
        /// <param name="message">Log message which is written in the log file</param>
        /// <param name="logFileName">Name and location of the log file</param>
        /// <param name="messageType">Define Message Types</param>
        /// <param name="actor">Defines the Actor</param>
        void Log(string message, string messageType, string actor, string logFileName);
    }
}
