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
        
        public void Append(int data)//to append to linked list
        {
            AddLast(data);
            Console.WriteLine("{0} Appended to list", data);
        }

        public void InsertedAtPosition(int pos, int data)//to insert at a position
        {
            Node temp;
            int i;
            if(pos ==1)//if position is 1 then insert at start
            {
                temp = new Node(data);
                temp.next = head;
                head= temp;
                return;

            }
            Node n = head;
            for(i=1; i<pos-1 && n != null; i++)
            {
                n = n.next;
            }
            if(n == null)
            {
                Console.WriteLine("insert only upto " + i + "th position");
            }
            else
            {
                temp= new Node(data);
                temp.next=n.next;
                n.next=temp;
                Console.WriteLine("Node inserted at position : " + (i + 1));
            }
        }
     }
}