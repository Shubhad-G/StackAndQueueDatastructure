using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackOperations s = new StackOperations();
            int option;
            Console.WriteLine("implementation of Stack and queue datastructure using linked list");
            do
            {
                Console.WriteLine("\nStack operations\n1.Push\n2.pop\n\nQueue operations\n3.Enqueue\n4.Dequeue\n5.display\n");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter the element to be pushed into stack");
                        int element = Convert.ToInt32(Console.ReadLine());
                        s.push(element);
                        break;

                    case 2:
                        s.IsEmpty();
                        break;

                    case 3:
                        Console.WriteLine("enter the element to be pushed into queue");
                        int qElement = Convert.ToInt32(Console.ReadLine());
                        s.Enqueue(qElement);
                        break;

                    case 4:
                        s.Dequeue();
                        break;

                    case 5:
                        s.display();
                        break;
                }
            } while (option != 0);
            Console.ReadLine();
        }
    }
}
