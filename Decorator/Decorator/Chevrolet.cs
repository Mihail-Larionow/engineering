using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс Chevrolet
    internal class Chevrolet : AutoBase
    {
        //Конструктор Chevrolet
        public Chevrolet(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return CostBase * 1.2;
        }
    }
}
