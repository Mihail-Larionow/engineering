using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Абстрактный класс AutoBase
    abstract class AutoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostBase { get; set; }

        //Абстрактный метод GetCost
        public abstract double GetCost();

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Ваш автомобиль: \n{0} \nОписание: {1} \nСтоимость {2}\n",
            Name, Description, GetCost());
            return s;
        }
    }
}
