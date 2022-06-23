using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataStructures
{
    public class QueueTest1
    {
        public QueueTest1()
        {

        }
        public void Run()
        {
            // Creates and initializes a new Queue.
            Queue myQ = new Queue();
            myQ.Enqueue("Hellow");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues.PrintValue(myQ);

        }
    }
}
