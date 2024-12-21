using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {

        public enum Ranking { Bad, Ok, Good };

        public enum onOff : byte { On = 1, Off = 0 };

        static void Main(string[] args)
        {
            //onOff Status = onOff.On;
            Console.WriteLine();
           // Console.WriteLine($"Status is {Status}");

            Ranking r = Ranking.Ok;
            Console.WriteLine($"Ranking is {r}");
            Console.WriteLine($"Ranking is {r + 1}");

            Console.WriteLine($"Ranking is {r -1 }");

            bool res1 = Enum.IsDefined(typeof(Ranking), 3);
            Console.WriteLine($"{3} defined: {res1}");

            bool res2 = Enum.IsDefined(typeof(Ranking), Ranking.Good);
            Console.WriteLine($"{Ranking.Good}  is defined: {res2}");

            bool res3 = Enum.IsDefined(typeof(Ranking), Ranking.Bad);
            Console.WriteLine($"{Ranking.Bad}  is defined: {res3}");

            bool res4 = Enum.IsDefined(typeof(Ranking), 2);
            Console.WriteLine($"{2} defined: {res4}");

            bool res5 = Enum.IsDefined(typeof(Ranking), 5);
            Console.WriteLine($"{5} defined: {res5}");

            foreach (string s in Enum.GetNames(typeof(Ranking)))
                Console.WriteLine(s);


        }
    }
}
