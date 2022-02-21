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
       
        public void AddLast(int data) //Method to Add Node in Linked List
        {

            Node newnode = new Node(data);
            if (this.head == null)//condition to check head and add first Node.

            {
                this.head = newnode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("Inserted into node: " + newnode.data);
        }
        public void DisplayLinkedList()
        {
            Console.WriteLine("Display Nodes in the Linked list");
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("Currently Linked List is Empty");
                return;
            }
            else
            {
                while(temp.next != null)
                {
                    Console.WriteLine("Nodes are : "+temp.data);
                    temp = temp.next;   
                }
            }
        }

        public void AddFirst(int data)//to add node at first position
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newnode.data);
        }
        
    }
}