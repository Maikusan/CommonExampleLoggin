using System;
using System.IO;

namespace CommonExampleLoggin
{
    public class Logger : LoggerInterface
    {
        /// <summary>
        /// Creates Log File 
        /// </summary>
        /// <param name="fileName"></param>
        private void createLogFile(string fileName)
        {
            if (!File.Exists(fileName) && string.IsNullOrWhiteSpace(fileName))
            {
                File.Create(fileName);
            }
        }

        /// <summary>
        /// Logs message into log file.
        /// Creates log file if it not exists.
        /// </summary>
        /// <param name="message">Log message which is written in the log file</param>
        /// <param name="logFileName">Name and location of the log file</param>
        /// <param name="messageType">Define Message Types</param>
        /// <param name="actor">Defines the Actor</param>
        public void Log(string message, string messageType, string actor, string logFileName)
        {         
            if (!string.IsNullOrWhiteSpace(message) || !string.IsNullOrWhiteSpace(messageType) || !string.IsNullOrWhiteSpace(actor) || !string.IsNullOrWhiteSpace(logFileName))
            {
                if (logFileName.Contains(".txt"))
                {
                    createLogFile(logFileName);
                    File.AppendAllText(logFileName, string.Format("0:MM/dd/yy H:mm:ss zzz / {1} / {2} / {3}", DateTime.Now, messageType, actor, message));
                }
                else
                {
                    throw new Exception("logFileName is not .txt File");
                }
            }
            else
            {
                throw new Exception("Some parameters are null or empty");
            }
        }


    }
}
