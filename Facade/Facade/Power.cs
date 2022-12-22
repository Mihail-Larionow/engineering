using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Класс Power
    internal class Power
    {
        public event EventHandler powerevent; //Держатель событий
        private int _power; //Мощность

        //MicrowavePower
        public int MicrowavePower
        {
            get { return _power; }
            set
            {
                _power = value;
                if (powerevent != null)
                    powerevent(this, new EventArgs());
            }
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Задана мощность {0}w ", MicrowavePower);
            return s;
        }
    }
}
