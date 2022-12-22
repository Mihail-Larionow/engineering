using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс MediaNAV
    internal class MediaNAV : DecoratorOptions
    {
        //Конструктор MediaNAV
        public MediaNAV(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Современный";
            Description = p.Description + ". " + this.Title + ". Обновленная мультимедийная навигационная система";
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15.99;
        }
    }
}
