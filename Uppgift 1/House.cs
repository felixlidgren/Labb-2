using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_1
{
    public class House
    {
        public string Name { get; set; }
        public string HouseGhost { get; set; }
        public string Mascot { get; set; }
        public string Password { get; set; }

        public List<Wizard> members;

        public bool isVowel(char character)
        {
            string allVowels = "aouåeiyäöAOUÅEIYÄÖ";
            bool isVowel = false;

            foreach (char vow in allVowels)
            {
                if (vow == character)
                {
                    isVowel = true;
                    break;
                }
            }
            return isVowel;
        }

        public bool isConsonant(char character)
        {
            string allConsonants = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            bool isConsonant = false;

            foreach (char cons in allConsonants)
            {
                if (cons == character)
                {
                    isConsonant = true;
                    break;
                }

            }
            return isConsonant;
        }

        public virtual bool CountLetter (string Password) 
        {
            int letters = 0;
            bool correctLength = true;

            foreach (char character in Password) 
            {
                letters++;

                if (letters >= 5) 
                {
                    correctLength = true;
                }

                else 
                {
                    correctLength = false;
                }
            }
            return correctLength;
        }

        public virtual bool CtrlPassword (string PasswordChange) 
        {
            char lastLetter = PasswordChange[PasswordChange.Length - 1];
            bool ctrlPassword = true;

            if (isVowel(PasswordChange[0]) == true && CountLetter(PasswordChange)== true && isConsonant(lastLetter)) 
            {
                ctrlPassword = true;
            }
            else 
            {
                ctrlPassword = false;
            }

            return ctrlPassword;
        }

        public bool NewPassword (string oldPassword, string newPassword) 
        {
            bool nextPassword = true;

            if (oldPassword == Password && CtrlPassword(newPassword) == true) 
            {
                Password = newPassword;
                nextPassword = true;
            }
            else 
            {
                nextPassword = false;
            }
            return nextPassword;

        }
    }


    
}
