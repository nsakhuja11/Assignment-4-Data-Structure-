using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Queue : IAssignmentInterface
    {
        private int[] arr_queue = new int [100];
        private int rear = 0;
        private int front = 0;

        private bool isEmpty()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool isFull()
        {
            if (rear == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void add(int value)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            arr_queue[rear++] = value;
        }
        public void remove()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            front++;
        }
        public void display()
        {
            for (int i = front; i < rear; i++)
            {
                Console.Write(arr_queue[i] + " ");
            }
            Console.WriteLine();
        }
        public void sort()
        {
            int temp;
            for (int i = front; i < rear-1; i++)
            {
                for (int j = i + 1; j < rear; j++)
                {
                    if (arr_queue[i] > arr_queue[j])
                    {
                        temp = arr_queue[i];
                        arr_queue[i] = arr_queue[j];
                        arr_queue[j] = temp;
                    }
                }
            }
            display();
        }
        public void peek()
        {
            Console.WriteLine(arr_queue[front]);
        }
    }
}
