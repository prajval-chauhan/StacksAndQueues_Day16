using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues_Day16
{
    class LinkedListQueue
    {
        Node head = null;
        /// <summary>
        /// Adds the given value to the end of the queue
        /// Similar to the Append operation 
        /// </summary>
        /// <param name="data">The data.</param>
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the queue", node.data);
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data +" ");
                temp = temp.next;
            }
        }
        /// <summary>
        /// Removes the first added element in the queue.
        /// </summary>
        internal void Dequeue()
        {
            if(this.head == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Node temp = this.head;
            this.head = this.head.next;
            Console.WriteLine("{0} is removed from the queue", temp.data);
        }
    }
}
