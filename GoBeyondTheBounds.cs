/*
 * Kelvin Penn
 * Bellevue University
 * Business System Programming
 * This program tests a try block to see if it goes over the array limits
 */

using System;

namespace GoBeyondTheBounds
{
    class GoBeyondTheBounds
    {
        static void Main(string[] args)
        {

            {
                int[] Array = { 4, 7, 10, 12, 8 };

                try
                {
                    for (int x = 0; x < 10; x++)
                    {
                        int rate = Array[x];
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Now you've gone too far.");
                }
            }

        }

    }
}