using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayListDemo();
            //ListDemo();
            //SortedListDemo();
            //QueueDemo();
            StackDemo();
        }

        private static void ArrayListDemo()
        {
            ArrayList numbers = new ArrayList();
            numbers.Add(1);
            numbers.Add(2);
            //numbers.Add("Test");

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = (int)numbers[i];
                sum += number;
            }

            Console.WriteLine("The sum of the array is "+ sum + ".");
        }

        private static void ListDemo()
        {
            List<int> numbers = new List<int>();
            numbers.Add(14);
            numbers.Add(23);

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int number = (int)numbers[i];
                sum += number;
            }

            Console.WriteLine("The sum of the list is " + sum + ".");
        }

        private static void SortedListDemo()
        {

            // With Separate Statements
            SortedList<string, decimal> saleList = new SortedList<string, decimal>();
            saleList.Add("FrankleP", 32432.3432m);
            saleList.Add("AdamsA", 3943.234m);
            saleList.Add("PotterE", 34234.234m);

            // With a collection initializer
            SortedList<string, decimal> saleList0 = new SortedList<string, decimal>()
            {
                {"FrankleP", 232432.324m}, {"AdamsA" , 2324.324m}
            };

            // With Index inside a collection initializer
            SortedList<string, decimal> saleList1 = new SortedList<string, decimal>()
            {
                ["FrankleP"] = 23234.234m,
                ["AdamsA"] = 232.234m
            };

            // Converts the sortedlist to a tab-delimited string
            string saleTableString = "";
            foreach(KeyValuePair<string, decimal> employeeSalesEntry in saleList)
            {
                saleTableString += employeeSalesEntry.Key + "\t" +
                    employeeSalesEntry.Value + "\n";
            }

            Console.WriteLine(saleTableString);

        }


        private static void QueueDemo()
        {
            Queue<string> nameQueue = new Queue<string>();

            nameQueue.Enqueue("Boehm");
            nameQueue.Enqueue("Martinez");
            nameQueue.Enqueue("Murach");

            string name = "";
            while(nameQueue.Count > 0)
            {
                name += nameQueue.Dequeue() + "\n";
            }

            Console.WriteLine(name);
        }

        private static void StackDemo()
        {
            Stack<string> nameQueue = new Stack<string>();

            nameQueue.Push("Boehm");
            nameQueue.Push("Martinez");
            nameQueue.Push("Murach");

            string name = "";
            while (nameQueue.Count > 0)
            {
                name += nameQueue.Pop() + "\n";
            }

            Console.WriteLine(name);
        }
    }
}
