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
            /* LinkedList customLinkedList = new LinkedList();
             customLinkedList.AddLast(56);
             customLinkedList.AddLast(30);
             customLinkedList.AddLast(70);
             Console.WriteLine("Nodes inserted in to list");
             customLinkedList.DisplayLinkedList();


             customLinkedList.AddFirst(70);
             customLinkedList.AddFirst(30);
             customLinkedList.AddFirst(56);
             customLinkedList.DisplayLinkedList();*/

            /*LinkedList customLinkedList = new LinkedList();
            customLinkedList.Append(56);
            customLinkedList.Append(30);
            customLinkedList.Append(70);
            customLinkedList.Append(77);
            customLinkedList.DisplayLinkedList();*/

            /* LinkedList customLinkedList = new LinkedList();
             customLinkedList.Append(56);
             customLinkedList.Append(70);
             customLinkedList.DisplayLinkedList();
             customLinkedList.InsertedAtPosition(3, 30);
             customLinkedList.DisplayLinkedList();*/

            /*LinkedList customLinkedList = new LinkedList();
            customLinkedList.Append(56);
            customLinkedList.Append(70);
            customLinkedList.DisplayLinkedList();
            customLinkedList.InsertAtPosition(2, 30);
            customLinkedList.DisplayLinkedList();
            customLinkedList.DeleteFirst();
            customLinkedList.DisplayLinkedList();*/


            LinkedList customLinkedList = new LinkedList();
            customLinkedList.Append(56);
            customLinkedList.Append(70);
            customLinkedList.DisplayLinkedList();
            customLinkedList.InsertAtPosition(3, 30);
            customLinkedList.DisplayLinkedList();
            customLinkedList.DeleteFirst();
            customLinkedList.DisplayLinkedList();
            customLinkedList.DeleteLast();
            customLinkedList.DisplayLinkedList();
            customLinkedList.SearchNode(30);
            customLinkedList.InsertAfter(15, 30);
            customLinkedList.DisplayLinkedList();
            Console.ReadLine();
        }
    }
}
