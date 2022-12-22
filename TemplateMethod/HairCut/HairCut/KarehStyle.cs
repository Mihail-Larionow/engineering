using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut
{
    //Класс KarehStyle наследующий абстрактный класс HairStyle
    internal class KarehStyle : HairStyle
    {
        //Конструктор KarehStyle
        public KarehStyle(string a) : base(a) { }

        //Переопределенный метод Cutting
        public override void Cutting()
        {
            stepList.Add(Beggining);
            stepList.Add("Помоем");
            stepList.Add("Посушим");
            stepList.Add("Пострижем");
            stepList.Add("Каре");
        }
    }
}
