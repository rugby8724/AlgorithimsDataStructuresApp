using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsDataStructures.LinkedList
{
    public class LinkedList
    {
        public Node? Head {  get; set; }
        public void InsertHead(int data)
        {
            //Create the Node
            Node newNode = new Node();
            // put the data in the node
            newNode.Data = data;
            newNode.Next = Head;
            Head = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = Head;
            Head = Head.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating thur list...");
            Node current = Head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = Head;
            while(current.Next!= null) 
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;

        }
    }
}
