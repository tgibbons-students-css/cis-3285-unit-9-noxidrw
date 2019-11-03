using System;
using System.IO;
using SingleResponsibilityPrinciple.Contracts;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace SingleResponsibilityPrinciple
{
    /**
     * Added my changes to Git
     * 
     * @author William Dixon
     * @version Assignment part 2
     */

    public class ConsoleLogger : ILogger
    {
        public void LogWarning(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("WARN: ", message), args);
            using (StreamWriter logfile = File.AppendText("log.xml"))
            {
                logfile.WriteLine("<log><message>" + message + "</message></log> ", args);
            }
        }

        public void LogInfo(string message, params object[] args)
        {
            Console.WriteLine(string.Concat("INFO: ", message), args);
        }
    }
}
