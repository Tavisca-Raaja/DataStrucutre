using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    
    class Queue : IFunctionality
    {
        public static int CurrentLength;
        QueueStructure Enqueue = null;
        QueueStructure Dequeue = null;
        QueueStructure queue = null;
        QueueStructure Current = null;
        QueueStructure Prev = null;
        public void AddElements(int Value)
        {
            queue = Enqueue;
            if (queue == null)
            {
                queue = new QueueStructure();
                queue.Data = Value;
                queue.NextPtr = null;
                CurrentLength++;
                Enqueue = queue;
            }
            else
            {
                if (CurrentLength < queue.QueueLength)
                {
                    Current = Enqueue;
                    while (Current.NextPtr != null)
                        Current = Current.NextPtr;
                    Current.NextPtr = new QueueStructure();
                    Current = Current.NextPtr;
                    Current.Data = Value;
                    Current.NextPtr = null;
                    CurrentLength++;
                   // Console.WriteLine(CurrentLength);
                }
                else
                    Console.WriteLine("Queue is Full");
            }

        }

        public void DisplayElements()
        {
            queue = Enqueue;
            if (queue == null)
                Console.WriteLine("No Elements To Display");
            while (queue!=null)
            {
                Console.Write(queue.Data+" <- ");
                queue = queue.NextPtr; 
            }
        }

        public void RemoveElements()
        {
            if (CurrentLength == 0)
                Console.WriteLine("No Elements in Queue");
            if(CurrentLength==1)
            {
                CurrentLength = 0;
                Enqueue = null;
            }
            else
            {
                Enqueue = Enqueue.NextPtr;
            }
            Console.WriteLine(" Element delete");
        }

        public void SortElements()
        {
            for(int queuelength=0;queuelength<CurrentLength;queuelength++)
            {
                Current = Enqueue;
                Prev = Enqueue;

                while (Current != null)
                {
                    if (Prev.Data > Current.Data)
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
        public void isEmpty()
        {
            if (CurrentLength == 0)
                Console.WriteLine("Stack Is Empty");
            else
                Console.WriteLine("Stack Is Not Empty");
        }
        public void isFull()
        {
            if (CurrentLength == 10)
                Console.WriteLine("stack is Full");
            else
                Console.WriteLine("stack is Not Full");
        }
        public void Peek()
        {
            Console.WriteLine("TOp Element:"+Enqueue.Data);
        }
    }
}
