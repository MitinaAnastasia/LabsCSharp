using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public class DigitalCamera : Camera
    {
        public int memory { get; set; }
        public int battery_volume { get; set; }

        public DigitalCamera() : base()
        {
            this.memory = 4;
            this.battery_volume = 1000;
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
