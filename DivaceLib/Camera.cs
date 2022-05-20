using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public abstract class Camera : Divace
    {
        public string brand { get; set; }
        public string diaphragms { get; set; }
        public int zoom { get; set; }

        public Camera()
        {
            this.brand = "Sony";
            this.diaphragms = "1/8";
            this.zoom = 2;
        }

        public string status(bool vkl)
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

        public string power(int percent)
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

        private string foto()
        {
            return "Фотография успешно сделана";
        }

        private string zooming(bool val)
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
