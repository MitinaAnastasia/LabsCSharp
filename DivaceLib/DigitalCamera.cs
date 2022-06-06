using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public class DigitalCamera : Camera
    {
        public int Memory { get; set; }
        public int BatteryVolume { get; set; }

        public DigitalCamera() : base()
        {
            Memory = 4;
            BatteryVolume = 1000;
        }

        public string DeletePhoto()
        {
            return "Фото удалено";
        }

        public string WatchPhoto()
        {
            return "Режим просмотра фотографий включен";
        }

    }
}
