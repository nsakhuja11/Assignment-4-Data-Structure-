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
    class Linked_List : IAssignmentInterface
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
            Console.WriteLine("Last Node Removed");
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

        public void sort()
        {
            int swapTemp;
            node temp;
            node temp1;
            temp = head;
            while (temp.next != null)
            {
                temp1 = temp.next;
                while (temp1 != null)
                {
                    if (temp.data > temp1.data)
                    {
                        swapTemp = temp.data;
                        temp.data = temp1.data;
                        temp1.data = swapTemp;
                    }
                    temp1 = temp1.next;
                }
                temp = temp.next;
            }
            display();
        }
    }
}
