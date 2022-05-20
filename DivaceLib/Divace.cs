using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivaceLib
{
    public interface Divace
    {
        string brand { get; set; }
        string status(bool vkl);
        string power(int percent);
    }

}
