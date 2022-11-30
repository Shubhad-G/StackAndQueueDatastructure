﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class StackOperations
    {
       public Node top;
        public void push(int data)
        {
            Node item = new Node(data);
            if (top == null)
            {
                top=item;
                Console.WriteLine("{0} is pushed into the stack",item.data);
            }
            else
            {
               item.next=top;
                top=item;
                Console.WriteLine("{0} is pushed into the stack", item.data);
            }
        }
        public void peek()
        {
            if (top == null)
                Console.WriteLine("stack is empty");
            else
                Console.WriteLine(top.data+" is at the top of the stack");
        }
        public void pop()
        {
            if (top == null)
                Console.WriteLine("stack is empty,hence pop operation is not possible");
            else
            {
                Console.WriteLine("\n{0} poped from the stack", top.data);
                top = top.next;
            }
        }
        public void IsEmpty()
        {
<<<<<<< HEAD

=======
>>>>>>> 939cf2302caa4a822fd74a36a31eb0e84fd0da7a
            while(top!=null)
            {
              peek();
              pop();
<<<<<<< HEAD

=======
>>>>>>> 939cf2302caa4a822fd74a36a31eb0e84fd0da7a
            }
        }
        public void display()
        {
            Node temp = top;
            if(temp == null)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine("elements are");
                while (temp != null)
                {
                    Console.WriteLine("\n"+temp.data+" ");
                    temp=temp.next;
                }
            }
        }
        public void Enqueue(int data)
        {
            Node item = new Node(data);
            if (top == null)
            {
                top = item;
                Console.WriteLine("{0} is added to the queue", top.data);
            }
            else
            {
                Node temp=top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = item;
            }
            Console.WriteLine("{0} is added to the queue", item.data);
        }
         
        public void Dequeue()
        {
            Node temp=top;
            if(top == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                // while(temp.next != null)
                // {
                //     temp=temp.next;
                //     temp.next = null;
                // }
                //Console.WriteLine("{0} is removed from the queue",temp.data);
                if (top == null)
                    Console.WriteLine("queue is empty,hence dequeue operation is not possible");
                else
                {
                    Console.WriteLine("\n{0} removed from the queue", top.data);
                    top = top.next;
                }

            }

        }
    }
}
