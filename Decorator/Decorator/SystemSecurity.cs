using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //Класс SystemSecurity
    internal class SystemSecurity : DecoratorOptions
    {
        //Конструктор SystemSecurity
        public SystemSecurity(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Повышенной безопасности";
            Description = p.Description + ". " + this.Title + ". Передние боковые подушки безопасности, ESP -система динамической стабилизации автомобиля";
        }

        //Переопределенный метод GetCost
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
