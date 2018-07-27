using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class StackStructure
    {
        public int Data;
        public StackStructure Nextptr;
        public StackStructure()
        {
            Data =0;
            Nextptr= null;
        }
    }
}
