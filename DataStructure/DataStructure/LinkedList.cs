using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {

        public Node head;

        public void AddLast(int data) // To Add Node in Linked List
        {
            Node newnode = new Node(data);

            if (this.head == null) //condition to Check head and add first Node.
            {
                this.head = newnode;
            }
            else
            {

                Node temp = head;

                while (temp.next != null) //To check next address in Node.
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            Console.WriteLine("inserted into node: " + newnode.data);
        }


        public void DisplayLinkedList()//Display elements in the  list
        {
            Console.WriteLine("Display nodes of Linked List");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("Nodes are : " + temp.data);
                    temp = temp.next;
                }
            }
        }

        public void AddFirst(int data) //To Add Node at First position in Linked List
        {
            Node newnode = new Node(data);
            newnode.next = head;
            head = newnode;
            Console.WriteLine("{0} : Nodes inserted in Linked list ", newnode.data);
        }


        public void Append(int data)//To append 
        {
            AddLast(data);
            Console.WriteLine("{0} node Appended", data);
        }


        public void InsertAtPosition(int pos, int data) //To insert at specific position
        {
            Node temp;
            int i;

            if (pos == 1) //if position is 1 then insert at start
            {
                temp = new Node(data);
                temp.next = head;
                head = temp;
                return;
            }
            Node p = head;

            for (i = 1; i < pos - 1 && p != null; i++) //position may be more than available nodes so loop to traverse on condition if p is null then terminate loop
            {
                p = p.next;

            }

            if (p == null) //if p is null pop message
            {
                Console.WriteLine("you can insert only upto " + i + "th position");
            }

            else//if p is not null then create new node  & pass the data & p pointer to temp pointer & temp to p pointer
            {
                temp = new Node(data);
                temp.next = p.next;
                p.next = temp;
                Console.WriteLine("node inserted at position : " + (i + 1));
            }
        }

        public int DeleteFirst()//To delete node at first position 
        {
            if (this.head == null)
            {
                Console.WriteLine("List is already empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            Console.WriteLine("node deleted is " + deleteNode);
            return deleteNode;
        }


        public int DeleteLast() //To delete Last Node
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("List is already empty");
                return 0;
            }
            if (this.head.next == null)
            {
                this.head = null;
                return 0;
            }

            while (newNode.next.next != null)//checking for tail Node.
            {
                newNode = newNode.next;
            }
            int deleteLastNode = newNode.next.data;
            newNode.next = null;
            Console.WriteLine("node deleted at Last position is " + deleteLastNode);
            return deleteLastNode;
        }
    

        public int SearchNode(int value)//to search node
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("The searched node is : " + value);
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("{0} is not a Linked List Node", value);
            return 0;
        }
    }
}
