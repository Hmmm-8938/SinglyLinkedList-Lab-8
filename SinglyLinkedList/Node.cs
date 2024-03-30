using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        // This can be primative or an object data type
        public string data; // holds the data

        // pointer that points to the next node
        public Node next;

        public Node(string d)
        {
            data = d;
            next = null;
        }
    }
}
