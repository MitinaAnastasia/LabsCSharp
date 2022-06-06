using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    class PolaroidCamera : Camera
    {
        public int NumberOfFrames { get; set; }
        public int ColourVolume { get; set; }

        public PolaroidCamera() : base()
        {
            NumberOfFrames = 10;
            ColourVolume = 100;
        }

        public string PrintPhoto()
        {
            return "Фото сделано и распечатано";
        }
        public string Frames(bool frame)
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
