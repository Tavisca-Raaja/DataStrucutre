using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   
    class stack : IFunctionality
    {
        StackStructure Top = null;
        StackStructure Current = null;
        StackStructure Prev = null;
        StackStructure Base = null;
        static int count = 0;
        public void AddElements(int Value)
        {
            Base = Top;
          if(Top==null)
            {
                Base = new StackStructure();
                Base.Data = Value;
                Base.Nextptr = null;
                Top = Base;
                count++;
            }
          else
            {
                Current = new StackStructure();
                Current.Data = Value;
                Current.Nextptr = Top;
                Top = Current;
                count++;
            }
        }

        public void DisplayElements()
        {
            Base = Top;
            if (Base == null)
                Console.WriteLine("No Elements To Display");
            while (Base != null)
            {
                Console.Write(Base.Data + " -> ");
                Base = Base.Nextptr;
            }
               
        }

        public void RemoveElements()
        {

            if (Top == null)
                Console.WriteLine("No Elements To Remove");
            else
            {
                Top = Top.Nextptr;
                count--;
                Console.WriteLine(" Element delete");
            }
        }

        public void SortElements()
        {
            for (int stacklength = 0; stacklength < count; stacklength++)
            {
                Current = Top;
                Prev = Top;

                while (Current != null)
                {
                    if (Prev.Data > Current.Data)
                    {
                        int temp = Prev.Data;
                        Prev.Data = Current.Data;
                        Current.Data = temp;
                    }
                    Prev = Current;
                    Current = Current.Nextptr;
                }
            }
        }
        public void TopValue()
        {
            Console.WriteLine("TOp Value:"+Top.Data);
        }
    }
}
