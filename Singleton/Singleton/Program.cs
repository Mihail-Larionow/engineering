using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Singleton
    {
        static void Main(string[] args)
        {
            Log lg = Log.MyLog; //Экземпляр класса Log
            lg.LogExecution("Метод Main()"); //Вызов метода LogExecution
            double op = Operation.Run('-', 35); //Вызов метода Run
            op = Operation.Run('+', 30); //Вызов метода Run
        }
    }
}