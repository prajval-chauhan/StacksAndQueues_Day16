﻿using System;

namespace StacksAndQueues_Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            Console.WriteLine("\n--------------------------\nStack Operations\n--------------------------");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.isEmpty();
            Console.WriteLine("\n--------------------------\nQueue Operations\n--------------------------");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Display();
        }
    }
}
