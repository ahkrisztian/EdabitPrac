using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit.SehrSchwer
{
    public static class MaximumOccurrence
    {
        //Given a string text. Write a function that returns the character with the highest frequency.
        //If more than 1 character has the same highest frequency, return all those characters as a comma separated string.
        //If there is no repetition in characters, return "No Repetition".

        public static string MaxOcc(string text)
        {

            char[] textChars = text.ToCharArray();


            //Create dicitonaries with keys(character), values(sum of a character)
            var dictionary = new Dictionary<char, int>();

            foreach (char cText in text)
            {
                int counter = 0;

                foreach (char cArray in textChars)
                {
                    if (cArray == cText)
                    {
                        counter++;
                    }
                }

                if (counter > 1)
                {
                    if (!dictionary.ContainsKey(cText))
                    {
                        dictionary.Add(cText, counter);
                    }


                }
            }

            //If dicitonary is empty, there is No Repetition
            if (dictionary.Count == 0)
            {
                return "No Repetition";
            }


            //Search for a charachter or characters with a highest value
            List<char> result = new List<char>();

            var maxValue = dictionary.Values.Max();

            foreach (KeyValuePair<char, int> keyValuePair in dictionary)
            {
                if (keyValuePair.Value == maxValue)
                {
                    result.Add(keyValuePair.Key);
                }
            }


            return String.Join(",", result);

        }
    }
}
