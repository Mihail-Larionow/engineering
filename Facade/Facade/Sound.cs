using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Класс Sound
    internal class Sound
    {
        public event EventHandler soundevent; //Держатель событий
        private string squeek; //Звук

        //Squeek
        public string Squeek
        {
            get { return squeek; }
            set
            {
                squeek = value;
                if (soundevent != null)
                    soundevent(this, new EventArgs());
            }
        }

        //Метод SoundStart
        public void SoundStart()
        {
            Squeek = "Пип!";
        }

        //Метод SoundEnd
        public void SoundEnd()
        {
            Squeek = "Пиииип пиииип!";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Звук: {0}", Squeek);
            return s;
        }
    }
}
