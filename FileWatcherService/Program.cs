using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherService
{
   
    static class Program
    { 
        
        static void fn()
    {
        Console.WriteLine("hello this is checking me");
    }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] servicestorun;
            servicestorun = new ServiceBase[]
            {
                new Service1()
                //this is changing


            };
            ServiceBase.Run(servicestorun);
            //Service1 service = new Service1();
            //service.OnDebug();
            //System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}
