using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Logger logger = LogManager.GetLogger("startup");
            var logEventInfo = new LogEventInfo(LogLevel.Info,logger.Name, "starup app");
            logEventInfo.Properties.Add("EventID",1222);
            logEventInfo.Properties.Add("TASK", 1);
            logger.Info(logEventInfo);
            IService<Apc> service = new Service<Apc>();

            service.Add(new Apc() { Id = 5, NameType = "Brol5" });
            service.Add(new Apc() { Id = 2, NameType = "Brol2" });
            service.Add(new Apc() { Id = 32, NameType = "Brol32" });
            service.Add(new Apc() { Id = 1, NameType = "Brol1" });

            service.All().ForEach(t => Console.WriteLine(t));

            service.Remove(service.Get(1));

            Console.WriteLine("---------");

            service.All().ForEach(t => Console.WriteLine(t));
            logger.Info("end app");
            Console.ReadKey();
        }
    }
}
