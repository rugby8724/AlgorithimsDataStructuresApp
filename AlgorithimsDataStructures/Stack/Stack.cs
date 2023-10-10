using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithimsDataStructures.Stack
{
    public class Stack
    {
        // Array stacks you need a maxsize to init array
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }
        public int Top { get; set; }
        
        public Stack(int size)
        {
            this.MaxSize = size;
            this.StackArray = new string[MaxSize];
            // We give top -1 because array is zero index; if we don't it will skip the first element
            this.Top = -1;
        }

        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public string Pop()
        {
            int old_top = Top;
            Top--;
            return StackArray[old_top];
        }

        public string Peek()
        {
            return StackArray[Top];
        }

        public bool isEmpty()
        {
            return Top == 0;
        }

        public bool isFull()
        {
            return MaxSize == Top;
        }

    }
}
