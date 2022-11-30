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
            Console.WriteLine("implementation of Stack and queue datastructure using linked list");
            Console.WriteLine("Stack operations\n1.Push");
            StackOperations s = new StackOperations();
            s.push(70);
            s.push(30);
            s.push(56);
            s.display();
            s.IsEmpty();
            s.display();
            Console.ReadLine();
        }
    }
}
