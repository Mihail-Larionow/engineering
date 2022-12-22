using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut
{
    //Класс StraightStyle наследующий абстрактный класс HairStyle
    internal class StraightStyle : HairStyle
    {
        //Конструктор StraightStyle
        public StraightStyle(string a) : base(a) { }

        //Переопределенный метод Cutting
        public override void Cutting()
        {
            stepList.Add(Beggining);
            stepList.Add("Помоем");
            stepList.Add("Посушим");
            stepList.Add("Выпрямим");
            stepList.Add("Прямые волосы");
        }
    }
}
