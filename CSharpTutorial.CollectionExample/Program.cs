using System;
using System.Collections;

namespace CSharpTutorial.CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            object queueObject = "recai";
            queue.Enqueue(queueObject);
            Console.WriteLine(queue.ToArray()[0]);


            Console.Read();
        }
    }
}
