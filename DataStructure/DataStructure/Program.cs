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
            customLinkedList.AddLast(56);
            customLinkedList.AddLast(30);
            customLinkedList.AddLast(70);
            Console.WriteLine("Nodes inserted in to list");
            customLinkedList.DisplayLinkedList();
           
            
            customLinkedList.AddFirst(70);
            customLinkedList.AddFirst(30);
            customLinkedList.AddFirst(56);
            customLinkedList.DisplayLinkedList();
            Console.ReadLine();
         }
    }
}
