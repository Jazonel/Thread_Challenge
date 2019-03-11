using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;

namespace LogSpace
{
    
    public class LogManager
    {
        public readonly log4net.ILog _log;

        public void LogThis(string message, string typeOfLog)
        {
            XmlConfigurator.Configure();
            if (typeOfLog == "Error")
            {
                _log.Error(message);
                Console.WriteLine(message);
            }
        }

        public LogManager()
        {
            _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        }
            
    }
}
