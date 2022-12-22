using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс AutoStart
    internal class AutoStart : DecoratorOptions
    {
        //Конструктор AutoStart
        public AutoStart(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Автозапуск";
            Description = p.Description + ". " + this.Title + ". Система автозапуска";
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 5.99;
        }
    }
}
