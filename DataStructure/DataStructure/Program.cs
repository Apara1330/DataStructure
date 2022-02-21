using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Linked List");
            LinkedList customLinkedList = new LinkedList();
            customLinkedList.AddNode(56);
            customLinkedList.AddNode(30);
            customLinkedList.AddNode(76);
            Console.ReadLine();
         }
    }
}
