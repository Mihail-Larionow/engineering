using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    //Класс-фасад Microwave
    internal class Microwave
    {
        private Drive _drive; //Объект класса Drive
        private Power _power; //Объект класса Power
        private Sound _sound; //Объект класса Sound
        private Notification _notification; //Объект класса Notification

        //Конструктор Cook Microwave
        public Microwave(Drive drive, Power power, Sound sound, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
            _sound = sound;
        }

        //Метод Cook
        public void Cook()
        {
            _sound.SoundStart();
            _notification.StartNotification();
            _power.MicrowavePower = 900;
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
            _sound.SoundEnd();
        }

        //Метод Defrost
        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurlRight();
            _drive.TurlRight();
            _power.MicrowavePower = 500;
            _drive.Stop();
            _drive.TurlLeft();
            _drive.TurlLeft();
            _power.MicrowavePower = 200;
            _drive.Stop();
            _drive.TurlRight();
            _drive.TurlRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }

        
    }
}
