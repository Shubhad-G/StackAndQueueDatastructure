using System;
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
        public void display()
        {
            Node temp = top;
            if(temp == null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp=temp.next;
                }
            }
        }
    }
}
