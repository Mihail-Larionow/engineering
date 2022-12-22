using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс Renault
    internal class Renault : AutoBase
    {
        //Конструктор Renault
        public Renault(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return CostBase * 1.18;
        }
    }
}
