using System;
using System.Collections.Generic;
using System.Text;

namespace doubleLinkedList
{
    public class DLL
    {
        public Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            int temp_data;
            public Node(int d)
            {
                data = d;
            }
            public Node()
            {
                data = temp_data;
            }
        }
        public void display()
        {
            Node new_node = head;
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (new_node != null)
            {
                Console.WriteLine(new_node.data + " ");
                new_node = new_node.next;
            }
        }
        public void push(int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = head;
            new_Node.prev = null;
            if (head != null)
            {
                head.prev = new_Node;

            }
            head = new_Node;
            Console.WriteLine("first node added sucessfully");
        }

        public void AddLast(int new_data)
        {
            Node new_node = new Node(new_data);
            Node last = head;
            new_node.next = null;
            if (head == null)
            {
                new_node.prev = null;
                head = new_node;
                return;
            }
            while (last.next != null)
            {
                last = last.next;
            }

            //change the next of last Node
            last.next = new_node;
            //make the last node as previous of new node
            new_node.prev = last;
            Console.WriteLine("last number");



        }
        public void deleteAtFirst()
        {
            if (head!=null)
            {
                if (head.next==null)
                {
                    head = null;

                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    Node lastNode = temp.next;
                    lastNode = null;
                    temp.next = null;

                }
            }
          
        }
        public Node findElement(int searchKey)
        {
            while (this.head!=null)
            {
                if (this.head.data == searchKey)
                {
                    return this.head;
                }
                    this.head = this.head.next;
                    Console.WriteLine("element{0} found in list...", this.head.data);
                
              
            }

            return null;
           


        }
        public Node insertSortedList(int value)
        {
            Node newNode = new Node(value);
            if (head==null)
            {
                return newNode;
            }
            Node current = head;
            Node temp = null;
            while (current!=null&&current.data<newNode.data)
            {
                temp = current;
                current = current.next;
            }
            newNode.next = current;
            temp.next = newNode;
            return head;
        }

    }
}
