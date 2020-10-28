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
        /// <summary>
        /// Shows the value that is present at the top of the stack
        /// </summary>
        internal void Peek()
        {
            if(this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is at the top of the stack",this.top.data);
        }
        /// <summary>
        /// Deletes the value that is present at the top of the stack
        /// </summary>
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty. Deletion not possible");
                return;
            }
            Console.WriteLine("Value popped is : {0}",this.top.data);
            this.top = this.top.next;
        }
        /// <summary>
        /// Deletes all the contents of the stack
        /// </summary>
        internal void isEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
