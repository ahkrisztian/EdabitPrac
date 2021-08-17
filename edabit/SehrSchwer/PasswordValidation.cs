using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    public static class PasswordValidation
    {
        //Create a function that validates a password to conform to the following rules:

        //Length between 6 and 24 characters.
        //At least one uppercase letter(A-Z).
        //At least one lowercase letter(a-z).
        //At least one digit(0-9).
        //Maximum of 2 repeated characters.
        //"aa" is OK 👍
        //"aaa" is NOT OK 👎
        //Supported special characters:
        //! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .

        // ValidatePassword("P1zz@") ➞ false
        //// Too short.

        //ValidatePassword("iLoveYou") ➞ false
        //// Missing a number.

        //ValidatePassword("Fhg93@") ➞ true
        //// OK!
        ///edabit - Pickle

        public static bool PassWordValidator(string password)
        {
            List<char> supportedChars = new List<char>{
                '!',  '@', '#', '$', '%', '^', '&', '*', '(',  ')',  '+', '=',
                '_', '.', '-', '{', '}', '[', ']', ':', ';', '"', '?', '<', '>', ',', '.'};

            List<char> CharsOfPassword = password.ToCharArray().ToList();

            int countUpper = 0;
            int countLower = 0;
            int countDigit = 0;
            int specialChar = 0;
            bool MaxReapChar = true;

            foreach(char reapChar in CharsOfPassword)
            {
                string CharString3 = $"{reapChar}{reapChar}{reapChar}";

                if (password.Contains(CharString3))
                {
                    MaxReapChar = false;
                }
              
            }

            foreach(char c in CharsOfPassword)
            {
              

                if (Char.IsUpper(c))
                {
                    countUpper++;
                }

                if (Char.IsLower(c))
                {
                    countLower++;
                }

                if (Char.IsDigit(c))
                {
                    countDigit++;
                }

                if(!Char.IsLetter(c) && !Char.IsDigit(c) && supportedChars.Contains(c))
                {
                    specialChar++;
                }

            }

            if((CharsOfPassword.Count >= 6 && CharsOfPassword.Count <= 24))
            {
                if(countUpper > 0 && countLower > 0 && countDigit > 0 && specialChar > 0 && MaxReapChar == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
