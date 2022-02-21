using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
     class Node
    {
        
        public int data;//Instance variable
        public Node next;
        
        public Node(int data)//Constructor for Node
        {
            this.data = data;
            this.next = null;
        }
    }
}
