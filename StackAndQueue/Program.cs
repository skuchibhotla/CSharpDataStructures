using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stack */
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            /* Queue */
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);

            /* Stack Printing */
            Console.WriteLine("Popping one item from top of stack...");
            var itemStack = myStack.Pop();
            Console.WriteLine("{0} was popped. ", itemStack);

            Console.WriteLine("Printing Stack: ");
            while(myStack.Count != 0)
            {
                var poppedItem = myStack.Pop();
                Console.WriteLine(poppedItem);
            }

            /* Queue Printing */
            Console.WriteLine("Popping one item from top of stack...");
            var itemQueue = myQueue.Dequeue();
            Console.WriteLine("{0} was popped. ", itemQueue);

            Console.WriteLine("Printing Stack: ");
            while (myQueue.Count != 0)
            {
                var dequeueItem = myQueue.Dequeue();
                Console.WriteLine(dequeueItem);
            }

            Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}
