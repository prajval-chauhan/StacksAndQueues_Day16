using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues_Day16
{
    class LinkedListStack
    {
        private Node top;
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// and makes the stack pointer points to null by default
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// Pushes the specified value on the top of the stack
        /// </summary>
        /// <param name="value">The value.</param>
        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to the stack",value);
        }
        /// <summary>
        /// Uses iteration to display the contents of the stack
        /// </summary>
        internal void Display()
        {
            Node temp = this.top;
            Console.WriteLine("The contents of the stack are: ");
            while(temp != null)
            {
                Console.Write(temp.data +" ");
                temp = temp.next;
            }
        }
    }
}
