using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinkedList
    {
        public Node head;
       
        public void AddNode(int data) //Method to Add Node in Linked List
        {

            Node newnode = new Node(data);
            if (this.head == null)//condition to check head and add first Node.

            {
                this.head = newnode;
            }
            else
            {
                var lastNode = GetLastNode();
                lastNode.next = newnode;
            }
            Console.WriteLine("inserted into node: " + newnode.data);
        }

        public Node GetLastNode()
        {
            Node temp = head; //Temp Node to reference to iterate through nodes & not break node
            while (temp.next != null) //Loop to check next address in Node.
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}