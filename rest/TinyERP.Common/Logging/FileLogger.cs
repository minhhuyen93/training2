namespace TinyERP.Common.Logging
{
    using log4net;
    public class FileLogger : ILogger
    {
        private ILog logger = log4net.LogManager.GetLogger("FileLogger");
        public void Error(object obj)
        {
            this.logger.Error(obj);
        }
    }
}
