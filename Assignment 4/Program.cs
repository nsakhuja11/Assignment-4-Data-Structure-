using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            Stack stack = new Stack();
            Linked_List Llist = new Linked_List();
            int choice;
            Console.WriteLine("Enter 1 for Linked List, 2 for Stack and 3 for Queue");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int cont = 1;
                    while (cont == 1)
                    {
                        int ch;
                        Console.WriteLine("Enter 1 to ADD, 2 to Remove, 3 to Display");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                int val;
                                Console.WriteLine("Enter the value to be inserted: ");
                                val = Convert.ToInt32(Console.ReadLine());
                                Llist.add(val);
                                break;

                            case 2:
                                Llist.remove();
                                break;

                            case 3:
                                Llist.display();
                                break;
                        }

                        Console.WriteLine("Enter 1 to continue with Linked List or 0 to exit");
                        cont = Convert.ToInt32(Console.ReadLine());
                    }
                    break;
                
                //case 2:

            }
        }
    }
}
