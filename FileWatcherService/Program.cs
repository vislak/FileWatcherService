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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] servicestorun;
            servicestorun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(servicestorun);
            //Service1 service = new Service1();
            //service.OnDebug();
            //System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }
}
