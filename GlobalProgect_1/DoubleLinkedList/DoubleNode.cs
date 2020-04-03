using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalProgect_1.DoubleLinkedList
{
    class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Previos { get; set; }
        public DoubleNode Next { get; set; }
        

        public DoubleNode (int value)
        {
            Value = value;
            Previos = null;
            Next = null;
        }
    }
}
