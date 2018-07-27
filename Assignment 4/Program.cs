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
            int cont = 1;
            Console.WriteLine("Enter 1 for Linked List, 2 for Stack and 3 for Queue");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    while (cont == 1)
                    {
                        int ch;
                        Console.WriteLine("Enter 1 to Add, 2 to Remove, 3 to Display, 4 to Sort");
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

                            case 4:
                                Llist.sort();
                            break;
                        }

                        Console.WriteLine("Enter 1 to continue with Linked List or 0 to exit");
                        cont = Convert.ToInt32(Console.ReadLine());
                    }
                break;
                
                case 2:
                    while (cont == 1)
                    {
                        int ch;
                        Console.WriteLine("Enter 1 to Add, 2 to Remove, 3 to Display, 4 to Sort or 5 to Get Top Value");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                int val;
                                Console.WriteLine("Enter the value to be inserted: ");
                                val = Convert.ToInt32(Console.ReadLine());
                                stack.add(val);
                            break;

                            case 2:
                                stack.remove();
                            break;

                            case 3:
                                stack.display();
                            break;

                            case 4:
                                stack.sort();
                            break;

                            case 5:
                                stack.getTop();
                            break;
                        }

                        Console.WriteLine("Enter 1 to continue with Queue or 0 to exit");
                        cont = Convert.ToInt32(Console.ReadLine());
                    }
                break;
                
                case 3:
                    while (cont == 1)
                    {
                        int ch;
                        Console.WriteLine("Enter 1 to Add, 2 to Remove, 3 to Display, 4 to Sort or 5 to Get Front Value");
                        ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                int val;
                                Console.WriteLine("Enter the value to be inserted: ");
                                val = Convert.ToInt32(Console.ReadLine());
                                queue.add(val);
                            break;

                            case 2:
                                queue.remove();
                            break;

                            case 3:
                                queue.display();
                            break;

                            case 4:
                                queue.sort();
                            break;

                            case 5:
                                queue.peek();
                            break;
                        }
                        Console.WriteLine("Enter 1 to continue with Stack or 0 to exit");
                        cont = Convert.ToInt32(Console.ReadLine());
                    }
                break;
            }
        }
    }
}
