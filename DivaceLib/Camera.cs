using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public abstract class Camera : IDivace
    {
        public string Brand { get; set; }
        public string Diaphragms { get; set; }
        public int Zoom { get; set; }

        public Camera()
        {
            Brand = "Sony";
            Diaphragms = "1/8";
            Zoom = 2;
        }

        public string Status(bool vkl)
        {
            if (vkl)
            {
                return "Фотоаппарат включен";
            }
            else
            {
                return "Фотоаппарат выключен";
            }
        }

        public string Power(int percent)
        {
            if (percent >= 40)
            {
                return "Фотоаппарат заряжен, его заряд: " + (percent).ToString();
            }
            if (0 < percent && percent < 40)
            {
                return "Фотоаппарат слабо заряжен, его заряд: " + (percent).ToString();
            }
            if (percent == 0)
            {
                return "Фотоаппарат поставлен на зарядку, потому что его заряд: " + (percent).ToString();
            }
            return "";
        }

        private string DoPhoto()
        {
            return "Фотография успешно сделана";
        }

        private string Zooming(bool val)
        {
            if (val)
            {
                return "Вы успешно приблизили";
            }
            else
            {
                return "Вы успешно отдалили";
            }
        }

    }
}
