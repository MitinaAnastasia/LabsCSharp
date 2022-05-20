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
    public abstract class Camera : Device
    {
        public string brand { get; set; }
        public string diaphragms { get; set; }
        public int zoom { get; set; }

        public Camera(string brand, string diaphragms, int zoom)
        {
            this.brand = brand;
            this.diaphragms = diaphragms;
            this.zoom = zoom;
        }

        public void status(bool vkl)
        {
            if (vkl)
            {
                MessageBox.Show("Фотоаппарат включен");
            }
            else
            {
                MessageBox.Show("Фотоаппарат выключен");
            }
        }

        public void power(int percent)
        {
            if (percent >= 40)
            {
                MessageBox.Show("Фотоаппарат заряжен, его заряд: " + (percent).ToString());
            }
            if (0 < percent && percent < 40)
            {
                MessageBox.Show("Фотоаппарат слабо заряжен, его заряд: " + (percent).ToString());
            }
            if (percent == 0)
            {
                MessageBox.Show("Фотоаппарат поставлен на зарядку, потому что его заряд: " + (percent).ToString());
            }
        }

        public void foto()
        {
            MessageBox.Show("Фотография успешно сделана");
        }

        public void zooming(bool val)
        {
            if (val)
            {
                MessageBox.Show("Вы успешно приблизили");
            }
            else
            {
                MessageBox.Show("Вы успешно отдалили");
            }
        }

    }
}
