using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    class PolaroidCamera : Camera
    {
        public int number_of_frames { get; set; }
        public int colour_volume { get; set; }

        public PolaroidCamera() : base()
        {
            this.number_of_frames = 10;
            this.colour_volume = 100;
        }

        public string print_photo()
        {
            return "Фото сделано и распечатано";
        }
        public string frames(bool frame)
        {
            if (frame)
            {
                return "Кадры еще есть, фото сделано";
            }
            else
            {
                return "Кадры закончились, поэтому плёнку заменили";
            }
        }

    }
}
