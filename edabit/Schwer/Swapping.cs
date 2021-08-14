
using System.Collections.Generic;

namespace edabit.Schwer
{
    public static class Swapping
    {
        //There are three cups on a table, at positions A, B, and C. At the start, there is a ball hidden under the cup at position B.
        //However, I perform several swaps on the cups, which is notated as two letters. For example, if I swap the cups at positions A and B, I could notate this as AB or BA.
        //Create a function that returns the letter position that the ball is at, once I finish swapping the cups.The swaps will be given to you as an array.

        //cupSwapping(["AB", "CA", "AB"]) ➞ "C"

        // Ball begins at position B.
        // Cups A and B swap, so the ball is at position A.
        // Cups C and A swap, so the ball is at position C.
        // Cups A and B swap, but the ball is at position C, so it doesn't move.

        //##persolut edabit

        public static string cupSwapping(params string[] postions)
        {
            //Starting Character
            char start = 'B';

            string postionResult;

            foreach (var position in postions)
            {
                List<char> result = new List<char>();

                result.AddRange(position);


                //Change the characters postions and remove the other character
                //Starting postion will be the result[0];
                if (result.Contains(start))
                {
                    int index = result.IndexOf(start);

                    result.RemoveAt(index);

                    start = result[0];
                }

            }

            postionResult = start.ToString();

            return postionResult;

        }
    }
}
