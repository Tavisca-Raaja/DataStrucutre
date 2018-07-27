using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the DataStructure you want to work With:");
            Console.WriteLine("1. LinkedList");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Stack");
            int Choice = Convert.ToInt32(Console.ReadLine());
            int ContinueProcess = 1;
            switch(Choice)
            {
                case 1:
                    LinkedList Lst = new LinkedList();
                    Console.WriteLine("Linked List Functionalities:");
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. AddElement  2.DisplayELement  3.RemoveElement  4.SortElement 5.InsertAtSpecific 6.RemoveAtSpecific");
                        int FunctionChoice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (FunctionChoice == 1)
                        {
                            Console.WriteLine("Enter the Node Value:");
                            Lst.AddElements(Convert.ToInt32(Console.ReadLine()));
                        }
                           
                        else if (FunctionChoice == 2)
                            Lst.DisplayElements();
                        else if (FunctionChoice == 3)
                            Lst.RemoveElements();
                        else if (FunctionChoice == 4)
                            Lst.SortElements();
                        else if (FunctionChoice == 5)
                        {
                            Console.WriteLine("Enter the Position and Value:");
                            int position = Convert.ToInt32(Console.ReadLine());
                            int value = Convert.ToInt32(Console.ReadLine());
                            Lst.InsertAtSpecific(position,value);

                        }
                            
                        else
                        {
                            Console.WriteLine("Enter the Position:");
                            int position = Convert.ToInt32(Console.ReadLine());
                            Lst.RemoveAtSpecific(position);
                        }
                        Console.WriteLine("Enter 2 to exit");
                        ContinueProcess = Convert.ToInt32(Console.ReadLine());
                    } while (ContinueProcess == 1);
                    break;
                case 2:
                    Queue Line = new Queue();
                    Console.WriteLine("Queue Functionalities:");
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. AddElement  2.DisplayELement  3.RemoveElement  4.SortElement 5.IsEmpty 6.IsFull 7.Peek");
                        int FunctionChoice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (FunctionChoice == 1)
                        {
                            Console.WriteLine("Enter the Value:");
                            Line.AddElements(Convert.ToInt32(Console.ReadLine()));
                        }

                        else if (FunctionChoice == 2)
                            Line.DisplayElements();
                        else if (FunctionChoice == 3)
                            Line.RemoveElements();
                        else if (FunctionChoice == 4)
                            Line.SortElements();
                        else if (FunctionChoice == 5)
                            Line.isEmpty();
                        else if (FunctionChoice == 6)
                            Line.isFull();
                        else
                            Line.Peek();
                        Console.WriteLine("Enter 2 to exit");
                        ContinueProcess = Convert.ToInt32(Console.ReadLine());
                    } while (ContinueProcess == 1);
                    break;
                case 3:
                    stack  top= new stack();
                    Console.WriteLine("Queue Functionalities:");
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("1. AddElement  2.DisplayELement  3.RemoveElement  4.SortElement 5.TopValue");
                        int FunctionChoice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (FunctionChoice == 1)
                        {
                            Console.WriteLine("Enter the Value:");
                            top.AddElements(Convert.ToInt32(Console.ReadLine()));
                        }

                        else if (FunctionChoice == 2)
                            top.DisplayElements();
                        else if (FunctionChoice == 3)
                            top.RemoveElements();
                        else if (FunctionChoice == 4)
                            top.SortElements();
                        else if (FunctionChoice == 5)
                            top.TopValue();

                        Console.WriteLine("Enter 2 to exit");
                        ContinueProcess = Convert.ToInt32(Console.ReadLine());
                    } while (ContinueProcess == 1);
                    break;

            }

        }
    }
}
