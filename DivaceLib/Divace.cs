using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public interface IDivace
    {
        string Brand { get; set; }
        string Status(bool vkl);
        string Power(int percent);
    }

}
