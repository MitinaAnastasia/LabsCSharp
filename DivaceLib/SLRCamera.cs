using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    class SLRCamera : Camera
    {
        public double SizeOfExcerpt { get; set; } //размер выдержки
        public int PhotoQuality { get; set; }

        public SLRCamera() : base()
        {
            SizeOfExcerpt = 0.03;
            PhotoQuality = 8;
        }

        public string GateStatus(bool gate)
        {
            if (gate)
            {
                return "Затвор фотоаппарата опущен";
            }
            else
            {
                return "Затвор фотоаппарата поднят";
            }
        }

        public string VklFlash(bool vkl)
        {
            if (vkl)
            {
                return "Вспышка включена";
            }
            else
            {
                return "Вспышка выключена";
            }
        }


    }
}
