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
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogThis(string message, string typeOfLog)
        {
            XmlConfigurator.Configure();

            _log.Info(message);

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
