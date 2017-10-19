using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CommonExampleLoggin.Tests
{
    [TestClass]
    public class CommonExampleLoginUnitTest
    {
        private CommonExampleLoggin.Logger logger;

        [TestInitialize]
        public void Init()
        {
            logger = new CommonExampleLoggin.Logger();

        }

        [TestMethod]
        public void LogWithWrongParams()
        {
            string message = "This is a Message";
            string messageType = "This is a MessageType";
            string actor = "This is an Actor";
            string logFileName = "test";

            try
            {
                logger.Log(message, messageType, actor, logFileName);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("logFileName is not .txt File"));
            }
        }

        [TestMethod]
        public void LogWithMissingParams()
        {
            string message = "";
            string messageType = "";
            string actor = "";
            string logFileName = "";

            try
            {
                logger.Log(message, messageType, actor, logFileName);
            }
            catch(Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Some parameters are null or empty"));
            }

        }

        [TestMethod]
        public void Log()
        {
            string message = "This is a Message";
            string messageType = "This is a MessageType";
            string actor = "This is an Actor";
            string logFileName = "test.txt";

            logger.Log(message, messageType, actor, logFileName);

            var conntent = File.ReadAllText(logFileName);
            Assert.IsNotNull(conntent);
            Assert.IsTrue(conntent.Contains(message));
            Assert.IsTrue(conntent.Contains(messageType));
            Assert.IsTrue(conntent.Contains(actor));
        }
    }
}
