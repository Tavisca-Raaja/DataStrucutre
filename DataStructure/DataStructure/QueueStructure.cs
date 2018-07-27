using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class QueueStructure
    {
        public int Data;
        public QueueStructure NextPtr;
        public int QueueLength;

        public QueueStructure()
        {
            Data = 0;
            NextPtr = null;
            QueueLength = 10;

        }
    }
}
