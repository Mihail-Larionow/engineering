using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс AutoTransmission
    internal class AutoTransmission : DecoratorOptions
    {
        //Конструктор AutoTransmission
        public AutoTransmission(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". АКПП";
            Description = p.Description + ". " + this.Title + ". Автоматическая коробка передач";
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 99.99;
        }
    }
}
