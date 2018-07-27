using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    
    class LinkedList : IFunctionality
    {
        Node node=null;
        Node Head = null;
        Node Current = null;
        Node Prev = null;
        Node Temp = null;
        public static int Len=0;
        public void AddElements(int Value)
        {
            node = Head;
            
            if (node==null)
            {
               
                node = new Node();
                node.Data =Value;
                Console.WriteLine();
                node.NextPtr = null;
                Len++;
                Head = node;
                Current = node;
              //  Console.WriteLine(Node.Len+" node");
            }
            else
            {
               
                Current = Head;
                
                while (Current.NextPtr != null)
                 Current = Current.NextPtr;
                //Console.WriteLine(Current.Data+" "+Head.Data);
                Current.NextPtr = new Node();
                Current = Current.NextPtr;
                Current.Data = Value;
                Current.NextPtr = null;
                
               
                Current = node;
                Len++;
            }

        }

        public void DisplayElements()
        {
            node = Head;
            if (node== null)
                Console.WriteLine("No Elements To Display");
            else
            {

                while(node!=null)
                {
                    Console.Write(node.Data+" -> ");
                    node = node.NextPtr;
                }
                Console.WriteLine();
            }
            
        }

        public void RemoveElements()
        {
            node = Head;
            if (Head == null)
                Console.WriteLine("No Elements to delete");
            else
            {
                if (Head.NextPtr == null)
                {
                    Head = null;
                    Len = 0;
                    Console.WriteLine(" Element delete");
                }
                else
                {
                    while (node.NextPtr != null)
                    {
                        Prev = node;

                        node = node.NextPtr;
                    }
                    Prev.NextPtr = null;
                    Console.WriteLine(" Element delete");
                    Len--;
                }
            }
        }

        public void SortElements()
        {
           // node = Head;
            
            for (int nodePosition=0;nodePosition<Len;nodePosition++)
            {
                Current = Head;
                Prev = Head;
               
                while(Current!=null)
                {
                 if(Prev.Data>Current.Data)
                    {
                        int temp = Prev.Data;
                        Prev.Data = Current.Data;
                        Current.Data = temp;
                    }
                    Prev = Current;
                    Current = Current.NextPtr;
                }
             

            }
        }
        public void InsertAtSpecific(int Position,int value)
        {
            if (Position > Len)
                Console.WriteLine("Enter Correct Position Value");
            
            else
            {
                Current = Head;
                Prev = null;
                Node newNode = new Node();
                newNode.Data = value;
                newNode.NextPtr = null;
                if (Len == 1 || Position==1)
                {
                    newNode.NextPtr = Current;
                    Head = newNode;
                    Len++;
                }
                else
                {
                    for (int nodePosition = 0; nodePosition < Position-1; nodePosition++)
                    {
                        Prev = Current;
                  
                        Current = Current.NextPtr;
                       // Console.WriteLine(Prev.Data+" "+Current.Data);
                    }
                     newNode.NextPtr=Prev.NextPtr;
                    Prev.NextPtr = newNode;
                    Len++;

                }

            }

        }
        public void RemoveAtSpecific(int position)
        {
            Current = Head;
            Prev = null;

            if (position == 1 && Len == 1)
                Head = null;
            if(position>Len)
                Console.WriteLine("Enter Correct Position Value");
            else
            {
                if (position == 1)
                {
                    Head = Head.NextPtr;
                    Len--;
                }
                if (position == Len)
                {
                    while (Current.NextPtr != null)
                    {
                        Prev = Current;
                        Current = Current.NextPtr;
                    }
                    Prev.NextPtr = null;
                    Len--;
                }
                else
                {
                    for (int nodePosition = 0; nodePosition < position - 1; nodePosition++)
                    {
                        Prev = Current;
                        Current = Current.NextPtr;
                       // Console.WriteLine(Prev.Data + " " + Current.Data);
                    }
                    Temp = Current.NextPtr;
                    Prev.NextPtr = Temp;
                    Len--;
                }
            }

        }
    }
    }

