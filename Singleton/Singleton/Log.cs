using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Класс Log
    internal class Log
    {
        //Приватный конструктор Log
        private Log() { }

        //Метод LogExecution
        public void LogExecution(string mes)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                Loger(mes, w);
                w.Close();
            }
        }

        //Приватный статический метод Loger
        private static void Loger(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
            w.WriteLine("Действие: {0}", logMessage);
            w.WriteLine("-------------------------------");
        }

        //Отложенная инициализация Log
        static Lazy<Log> myLog = new Lazy<Log>(() => new Log());

        //Статический метод MyLog
        public static Log MyLog
        {
            get
            {
                return myLog.Value;
            }
        }
    }
}
