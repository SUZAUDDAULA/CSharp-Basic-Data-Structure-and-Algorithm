using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataStructures
{
    class Program
    {
        public static void Main(string[] args)
        {
            StackTest1 stackTest1 = new StackTest1();
            StackTest2 stackTest2 = new StackTest2();
            QueueTest1 queueTest1 = new QueueTest1();
            QueueTest2 queueTest2 = new QueueTest2();

            ////Stack Test
            //stackTest1.Run();
            //stackTest2.Run();

            //Queue Test
            //queueTest1.Run();
            queueTest2.Run();
           
            Console.ReadLine();
        }

       
    }
}
