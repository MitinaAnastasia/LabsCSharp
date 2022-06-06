using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

19. interface Устройство -> abstract class Фотоаппарат -> class Цифровой фотоаппарат.*/

namespace лаба3_с_шарп
{
    public class DigitalCamera : Camera
    {
        public int Memory { get; set; }
        public int BatteryVolume { get; set; }

        public DigitalCamera(string brand, string diaphragms, int zoom, int memory, int batteryVolume) : base(brand, diaphragms, zoom)
        {
            Memory = memory;
            BatteryVolume = batteryVolume;
        }

        public string delete_photo()
        {
           return "Фото удалено";
        }

        public string watch_photo()
        {
            return "Режим просмотра фотографий включен";
        }

    }
}
