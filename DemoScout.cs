/*
 * Kelvin Penn
 * Bellevue University
 * Business System Programming
 * This programm takes class constructors and for girl scouts and displays them in the main method
 * 12/6/2017
 */

using System;

class DemoScouts
{
    static void Main(String[] args)
    {


        GirlScout girl1 = new GirlScout("Jenny", 450, 3.25);
        Console.WriteLine(girl1);
        GirlScout girl2 = new GirlScout("Jaime", 465, 5.85);
        Console.WriteLine(girl2);
        Console.WriteLine("Our motto: {0}", GirlScout.scoutMotto);

    }
}
class GirlScout
{
    public const string scoutMotto = "to obey the Girl Scout Law";
    string scoutName;
    int scoutNumber;
    double duesOwed;

   
    public string ScoutName
    {
        get { return scoutName; }
        set { scoutName = value; }
    }
    public int ScoutNumber
    {
        get { return scoutNumber; }
        set { scoutNumber = value; }
    }

    public double DuesOwed
    {
        get { return duesOwed; }
        set { duesOwed = value; }
    }

    public GirlScout(string name, int number, double dues)
    {
        scoutName = name;
        scoutNumber = number;
        duesOwed = dues;

       
    }
    public GirlScout()
    {
    
    }
    public override string ToString()
    {
        return String.Format("Name {0}, Scout Number {1}, Dues Owed {2}", scoutName, scoutNumber, duesOwed);
    }
}
