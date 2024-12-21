using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Privacy_Leak_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Hanne", new Date(1926, 12, 24));

            Date d = p.DateOfBirth;
            d.Year -= 100;
            d.Month -= 2;
            Console.WriteLine("{0}", p);

            Date today = new Date(2006, 8, 31);
            Console.WriteLine("Age of Hanne as of {0} : {1}.", today, p.AgeAsOf(today));
        }
    }
}
