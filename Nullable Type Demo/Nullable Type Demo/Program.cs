using System;

namespace Nullable_Type_Demo
{

    public struct a
    {
        public int Value;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IntSequence is1 = new IntSequence(-5, -1, 7, -8, 13),
                is2 = new IntSequence();

            int? x = null;

            ReportMinMax(is1);
            ReportMinMax(is2);

            //a a = new a();
            //a.Value = 5;
            //Console.WriteLine(a);

        }

        // The property HasValue can be applied 
        // on a value of a nullable type.
        public static void ReportMinMax(IntSequence iseq)
        {
            if(iseq.Min().HasValue && iseq.Max().HasValue)
                Console.WriteLine("Min: {0}. Max: {1}",
                            iseq.Min(), iseq.Max());
            else
                Console.WriteLine("Int sequence is empty");
        }
    }
}   
