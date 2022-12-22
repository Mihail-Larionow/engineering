using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Класс Notification
    internal class Notification
    {
        public event EventHandler notificationevent; //Держатель событий
        private string mess; //Мусор

        //MessageFin
        public string MessageFin
        {
            get { return mess; }
            set
            {
                mess = value;
                if (notificationevent != null)
                    notificationevent(this, new EventArgs());
            }
        }

        //Метод StartNotification
        public void StartNotification()

        {
            MessageFin = "Операция началась";
        }

        //Метод StopNotification
        public void StopNotification()
        {
            MessageFin = "Операция завершена";
        }

        //Переопределенный метод ToString
        public override string ToString()
        {
            string s = String.Format("Информация: {0}", MessageFin);
            return s;
        }
    }
}
