/*
 * Kelvin Penn
 * Bellevue University
 * Business Programming
 * This program takes user input to choose a style of wood for a table
 */

using System;

namespace Tables
{
    class Tables
    {
        static void Main(string[] args)
        {
            ConsoleWriteLine("Choose P for Pine, O for Oak or M for Mahogany to find a price for your table ");
            num Choice = Console.ReadLine();

            if (Choice == "P")
                Console.Write("The price for Pine is $100 ");
            else if (Choice == "O")
                Console.Write("The price for Oak is $225 ");
            else if (Choice == "M")
                Console.Write("The price for Mahogany is $310 ");
            
                Console.Write("$0 ");

        }
    }
}
