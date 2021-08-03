using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherService
{
   public static class Logger
    {
        public static void Log(string message)
        {
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt", message + Environment.NewLine);
        }
    }
}
