using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    public static class TrueAlphabeticalOrder
    {
        //Create a function which takes every letter in every word, and puts it in alphabetical order. Note how the original word lengths must stay the same.

        //TrueAlphabetic("hello world") ➞ "dehll loorw"
        //TrueAlphabetic("edabit is awesome") ➞ "aabdee ei imosstw"
        //TrueAlphabetic("have a nice day") ➞ "aaac d eehi nvy"

        public static string TrueAlphOrd(string text)
        {
            char[] textCharList = text.ToCharArray();


            //Get the indexes of a white spaces
            List<int> indexes = new List<int>();

            int counter = 0;

            foreach (char c in textCharList)
            {
                if (c == ' ')
                {
                    indexes.Add(counter);
                    counter++;
                }
                if (c != ' ')
                {
                    counter++;
                }
            }


            //Concat and Sort the string
            string trimmed = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));

            char[] trimmedCharArray = trimmed.ToCharArray();

            Array.Sort<char>(trimmedCharArray);

            string result = String.Join("", trimmedCharArray);


            //Put the white spaces to the rigth space
            string sortedString = indexes.ToArray().Aggregate(result, (s, i) => s.Insert(i, " "));

            return sortedString;

        }
    }
}
