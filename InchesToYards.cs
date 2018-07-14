using System;

/*
 * Kelvin Penn
 * Bellevue University
 * Business System Programming
 * This program converts inches to yards and remaining feet and inches
 */

namespace InchestoFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches = 45;
            Console.WriteLine("{0} inches equals", inches);
            ToFeet(inches);
            ToYards(inches);

        }
        public static void ToFeet(int inches)
        {
            int feet;
            int TotInches;
            feet = inches / 12;
            TotInches = inches % 12;
            Console.WriteLine("{0} feet and {1} inches", feet, TotInches);
        }

        public static void ToYards(int inches)
        {
            int feet;
            int yards;
            int TotFeet;
            int TotInches;

            feet = inches / 12;
            yards = feet / 3;
            TotFeet = feet % 3;
            TotInches = inches % 12;
            Console.WriteLine("{0} yards {1} feet and {2} inches", yards, TotFeet, TotInches);
            
        }
    }
}
