using System;
using edabit.Schwer;
using edabit.SehrSchwer;

namespace edabit
{
    class Program
    {
        static void Main(string[] args)
        {
            //New Drivinc License
            //Console.WriteLine(NewDrivingLicense.NewDrivincL("Aaron", 3, "Jane Max Olivia Sam"));  

            //Cup Swapping
            //Console.WriteLine(Swapping.cupSwapping("AB", "CA", "AB"));
            

            //Print Out 2D Grids
            Console.WriteLine(PrintGrid.Grids(rows: 4, cols: 2));


            //True Alphabetical Order
            //Console.WriteLine(TrueAlphabeticalOrder.TrueAlphOrd("edabit is awesome"));


            //Maximum Occurrence
            //Console.WriteLine(MaximumOccurrence.MaxOcc("Edabit"));


            //Least Common Multiple
            //int[] intArray = new int[] { 13, 6, 17, 18, 19, 20, 37, 50, 65, 99 };
            //int result = LeastCommonMultiple.LCM(integers: intArray);
            //Console.WriteLine($"The Least Common Multiple of {String.Join(",", intArray)} is {result}");

        }


    }
}