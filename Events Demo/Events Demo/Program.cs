using System;

namespace Events_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die();

            // we add an anonymous delegate to 
            // d1.twoSixesInARow, which reports the two sixes on the console.
            d1.twoSixesInARow += delegate (string mes) { Console.WriteLine(mes); };

            for(int i = 1; i < 5; i++)
            {
                d1.Toss();
                Console.WriteLine($"{i}: {d1.NumberOfEyes}");
            }
        }
    }
}
