using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_1
{
    class Slytherin:House
    {
        public Slytherin()
        {
            Name = "Slytherin";
            HouseGhost = "Den blodiga baronen";
            Mascot = "Orm";
            Password = "Han som inte får nämnas vid namn";
            
        }

        public override bool CountLetter(string Password)
        {
            int letters = 0;
            bool correctLengthSlyth = true;

            foreach (char character in Password)
            {
                letters++;

                if (letters >= 8)
                {
                    correctLengthSlyth = true;
                }

                else
                {
                    correctLengthSlyth = false;
                }
            }
            return correctLengthSlyth;

        }
        public override bool CtrlPassword(string PasswordChange)
        {
            char lastLetter = PasswordChange[PasswordChange.Length - 1];
            bool ctrlPassword = true;

            if (isConsonant(PasswordChange[0]) == true && CountLetter(PasswordChange) == true && isConsonant(lastLetter))
            {
                ctrlPassword = true;
            }
            else
            {
                ctrlPassword = false;
            }

            return ctrlPassword;
        }
    }

}
