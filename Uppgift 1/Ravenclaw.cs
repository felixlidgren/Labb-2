using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_1
{
    class Ravenclaw:House
    {
        public Ravenclaw()
        {
            Name = "Ravenclaw";
            HouseGhost = "Den grå damen";
            Mascot = "Örn";
            Password = "En ensam trollkarl";
            CtrlPassword(Password);
        }
    }
}
