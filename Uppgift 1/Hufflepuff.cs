using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_1
{
    class Hufflepuff : House
    {
        public Hufflepuff() 
        {
            Name = "Hufflepuff";
            HouseGhost = "Den tjocke munkbrodern";
            Mascot = "Grävling";
            Password = "En ensam trollkarl.";
            CtrlPassword(Password);

        }

        

    }
}
