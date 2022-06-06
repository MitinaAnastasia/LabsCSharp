using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace лаба5_6_с_шарп.Models
{
    interface Mechanics
    {
        void initializeMechanic();

        void repairLoader(ref Models.Conveyors CC_cConveyor);

        void controlRepair(ref Models.Conveyors CC_cConveyor);
    }
}
