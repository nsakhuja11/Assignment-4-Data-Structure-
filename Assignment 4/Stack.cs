using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Stack : IAssignmentInterface
    {
        private int[] arr_stack = new int[100];
        private int top=-1;

        private bool isEmpty()
        {
            if (top == -1)
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
            if (top == 99)
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
                Console.WriteLine("Stack is Full");
                return;
            }
            ++top;
            arr_stack[top] = value;
            Console.WriteLine("Value Added To Stack");
        }
        public void remove()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            --top;
            Console.WriteLine("Top Value removed");
        }
        public void display()
        {
            for (int i = 0; i <= top; i++)
            {
                Console.Write(arr_stack[i] + " ");
            }
            Console.WriteLine();
        }
        public void sort()
        {
            int temp;
            for (int i = 0; i < top; i++)
            {
                for (int j = i+1; j <= top; j++)
                {
                    if (arr_stack[i] > arr_stack[j])
                    {
                        temp = arr_stack[i];
                        arr_stack[i] = arr_stack[j];
                        arr_stack[j] = temp;
                    }
                }
            }
            display();
        }
        public void getTop()
        {
            Console.WriteLine(arr_stack[top]);
        }
    }
}
