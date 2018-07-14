using System;

namespace InchestoFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int inches = 45;
            Console.WriteLine("{0} inches equals", inches);
            ToFeet(inches);

        }
        public static void ToFeet(int inches)
        {
            int feet;
            int TotInches;
            feet = inches / 12;
            TotInches = inches % 12;
            Console.WriteLine("{0} feet and {1} inches", feet, TotInches);
        }
    }
}
