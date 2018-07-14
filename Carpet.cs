/*
 *Kelvin Penn
 * Bellevue University
 * Business Programming
 * This program takes user input for area and determines a price from it
 */

using System;

namespace Carpet
{
    public class Carpet 
    {
        static void Main(string[] args)
        {
            int length;
            float width;
            
            Console.WriteLine("Length of room in feet: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Width of room in feet: ");
            width = Convert.ToInt32(Console.ReadLine());
        
            int area = (length * width);
            double price = (area * .065)

            Console.WriteLine("The price for an area of {1} for carpet is {2} per square foot ",
               area, price);

        }
    }
}
