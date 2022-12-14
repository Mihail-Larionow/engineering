using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairCut
{
    //Класс CurlyStyle наследующий абстрактный класс HairStyle
    internal class CurlyStyle : HairStyle
    {
        //Конструктор CurlyStyle
        public CurlyStyle(string a) : base(a) { }

        //Переопределенный метод Cutting
        public override void Cutting()
        {
            stepList.Add(Beggining);
            stepList.Add("Помоем");
            stepList.Add("Посушим");
            stepList.Add("Пострижем");
            stepList.Add("Завьем");
            stepList.Add("Посушим");
            stepList.Add("Кудряшки");
        }
    }
}
