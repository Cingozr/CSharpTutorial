using System;
using System.Collections.Generic;

namespace CSharpTutorial.TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> tupleFirstUse =
                         new Tuple<int, string, string>(1, "Recai", "Cingoz");

            Console.WriteLine(tupleFirstUse.Item1);
            Console.WriteLine(tupleFirstUse.Item2);
            Console.WriteLine(tupleFirstUse.Item3);

            var tupleSecondUse = Tuple.Create(1, "Recai", "Cingoz");
            Console.WriteLine(tupleSecondUse.Item1);
            Console.WriteLine(tupleSecondUse.Item2);
            Console.WriteLine(tupleSecondUse.Item3);


            var tupleNumberUse = Tuple.Create(1, 2, 3);
            Console.WriteLine(tupleNumberUse.Item1);
            Console.WriteLine(tupleNumberUse.Item2);
            Console.WriteLine(tupleNumberUse.Item3);





            Console.ReadLine();
        }
    }
}
