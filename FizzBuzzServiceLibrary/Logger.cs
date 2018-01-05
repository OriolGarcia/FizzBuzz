using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzServiceLibrary
{



    public class Logger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void info(string message, int gravedad)
        {
            log.Debug(message + " Gravedad: " + gravedad);

        }
        public static void Debug(string message)
        {
            log.Debug(message );

        }
        public static void warning(string message, int gravedad)
        {
            log.Warn(message + " Gravedad: " + gravedad);

        }

        public static void error(string message,int gravedad){
            log.Error(message+" Gravedad: "+gravedad);
            
        }

    }
}
