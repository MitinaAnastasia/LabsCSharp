using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    class SLRCamera : Camera
    {
        public double size_of_excerpt { get; set; } //размер выдержки
        public int photo_quality { get; set; }

        public SLRCamera() : base()
        {
            this.size_of_excerpt = 0.03;
            this.photo_quality = 8;
        }

        public string gate_status(bool gate)
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

        public string vkl_flash(bool vkl)
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
