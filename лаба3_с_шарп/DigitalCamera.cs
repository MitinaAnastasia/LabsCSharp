using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Для интерфейса необходимо определить 1 свойство и 2 метода. 
Абстрактный класс должен содержать 3-5 свойств и 3-5 методов(включая унаследованные свойства интерфейса). 
Класс должен содержать дополнительно 2 свойства и 2 метода.
В программе реализовать работу со списком объектов, который должен содержать объекты типа интерфейса.

19. interface Устройство -> abstract class Фотоаппарат -> class Цифровой фотоаппарат.*/

namespace лаба3_с_шарп
{
    public class DigitalCamera : Camera
    {
        public int memory { get; set; }
        public int battery_volume { get; set; }

        public DigitalCamera(string brand, string diaphragms, int zoom, int memory, int battery_volume) : base(brand, diaphragms, zoom)
        {
            this.memory = memory;
            this.battery_volume = battery_volume;
        }

        public void delete_photo()
        {
            MessageBox.Show("Фото удалено");
        }

        public void watch_photo()
        {
            MessageBox.Show("Режим просмотра фотографий включен");
        }

    }
}
