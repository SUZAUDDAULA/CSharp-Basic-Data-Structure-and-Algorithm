using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataStructures
{
    public class QueueTest2
    {
        public QueueTest2()
        {

        }
        public void Run()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");
            // A queue can be enumerated without disturbing its contents.
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            Console.WriteLine("\nContents of the first copy:");
            foreach (var number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach(string number in queueCopy2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
            queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);

        }
    }
}
