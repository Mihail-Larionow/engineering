using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    //Класс ArithmeticProgression наследующий абстрактный класс Progression
    internal class ArithmeticProgression : Progression
    {
        //Конструктор ArithmeticProgression
        public ArithmeticProgression(int f, int l, int h) : base(f, l, h) { }

        //Переопределенный метод Progress
        public override void Progress()
        {
            int fF = First;
            do
            {
                progList.Add(fF);
                fF = fF + H;
            }
            while (fF < Last);
        }
    }
}
