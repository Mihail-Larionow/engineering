using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Класс Drive
    internal class Drive
    {
        public event EventHandler driveevent; //Держатель событий
        private string twist; //Вращение

        //Twist
        public string Twist
        {
            get { return twist; }
            set
            {
                twist = value;
                if (driveevent != null)
                    driveevent(this, new EventArgs());
            }
        }

        //Метод Drive
        public Drive()
        {
            Twist = "Исходная позиция";
        }

        //Метод TurlLeft
        public void TurlLeft()
        {
            Twist = "Поворот налево";
        }

        //Метод TurlRight
        public void TurlRight()
        {
            Twist = "Поворот направо";
        }

        //Метод Stop
        public void Stop()
        {
            Twist = "Стоп";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Привод: {0}", Twist);
            return s;
        }
    }
}
