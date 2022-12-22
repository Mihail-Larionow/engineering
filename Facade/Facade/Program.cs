using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        //Метод notification_notificationevent
        static void notification_notificationevent(object sender, EventArgs e)
        {
            Notification n = (Notification)sender;
            Console.WriteLine(n.ToString());
        }

        //Метод drive_driveevent
        static void drive_driveevent(object sender, EventArgs e)
        {
            Drive d = (Drive)sender;
            Console.WriteLine(d.ToString());
        }

        //Метод power_powerevent
        private static void power_powerevent(object sender, EventArgs e)
        {
            Power p = (Power)sender;
            Console.WriteLine(p.ToString());
        }

        //Метод power_powerevent
        private static void sound_soundevent(object sender, EventArgs e)
        {
            Sound s = (Sound)sender;
            Console.WriteLine(s.ToString());
        }

        static void Main(string[] args)
        {
            var drive = new Drive(); //Экземпляр класса Drive
            var power = new Power(); //Экземпляр класса Power
            var sound = new Sound(); //Экземпляр класса Sound
            var notification = new Notification(); //Экземпляр класса Notification
            var microwave = new Microwave(drive, power, sound, notification); //Экземпляр класса Microwave
            power.powerevent += power_powerevent; //Отслеживание событий объекта power
            drive.driveevent += drive_driveevent; //Отслеживание событий объекта drive
            sound.soundevent += sound_soundevent; //Отслеживание событий объекта sound
            notification.notificationevent += notification_notificationevent; //Отслеживание событий объекта notification

            Console.WriteLine("Разморозка");
            microwave.Defrost(); //Вызов метода Defrost

            Console.WriteLine();
            Console.WriteLine("Готовка");
            microwave.Cook(); //Вызов метода Cook
        }
    }
}