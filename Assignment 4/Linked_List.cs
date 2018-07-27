using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class node
    {
        public int data;
        public node next;
    }
    class Linked_List
    {
        node head = new node();
        public Linked_List()
        {
            head = null;
        } 
        public void add(int value)
        {
            node newnode = new node();
            newnode.data = value;
            newnode.next = null;
            node temp = new node();
            temp = head;
            if (temp == null)
            {
                head = newnode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
                
            Console.WriteLine("Element Added");

        }

        public void remove()
        {
            node temp = new node();
            temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }

        public void display()
        {
            node temp = new node();
            temp = head;
            while (temp.next != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine(temp.data);
        }
    }
}
