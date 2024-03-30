using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        public Node head;
        public int Count;

        public SinglyLinkedList()
        {
            head = null;
        }

        // Inserting at the start of the list
        public void AddFirst(string newData)
        {
            Node newNode = new Node(newData);
            // newnode points to where head currently points to
            newNode.next = head;
            // update head to point to their new node
            head = newNode;
            Count++;
        }

        // Adding to the end of a linked list
        public void AddLast(string newData)
        {
            Node newNode = new Node(newData);
            Node currentNode = head;


            // First check if the list is empty
            if (head == null)
            {
                head = newNode;
                return;
            }

            // Traverse the list checking if the next node is null
            // If the next node is null, then current position is the last node
            while (currentNode.next != null)
            {
                // move temp to point at the next node
                currentNode = currentNode.next;
            }

            // After getting to the last node
            // let the next pointer point to the new node
            currentNode.next = newNode;
            Count++;
        }

        // Deleting a node in the linkedList
        public void RemoveFirst()
        {
            Node temp = head;

            // This handles an empty list
            if (temp == null)
            {
                Console.WriteLine("This linkedList is Empty");
                return;
            }
            head = temp.next;
            Count--;
            return;
        }

        // Deleting a node in the linkedList
        public void RemoveLast()
        {
            Node temp = head;
 
            // This handles an empty list
            if (temp == null)
            {
                Console.WriteLine("This linkedList is Empty");
                return;
            }
            while (temp != null)
            {
                head = null;
                Count--;
                return;
            }
        }

        // printing content of a LinkedList
        public void DisplayList()
        {
            // Create an temproary node to print to the first element ==> head
            Node temp = head;

            // Traverse through the linkedList using the temp node
            while (temp != null)
            {
                // If temp node is not null, print the data
                Console.WriteLine(temp.data);
                // move temp to print to the next node
                temp = temp.next;
            }
        }

        public void GetValue(int index)
        {
            // First check if the list is empty
            if (head == null)
            {
                Console.WriteLine("This linkedList is Empty!");
                return;
            }

            Node temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            Console.WriteLine($"\n{temp.data}");
            return;
        }

        public void GetCount()
        {
            Console.WriteLine(Count);
        }
    }
}
