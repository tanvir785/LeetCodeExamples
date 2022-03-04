using System;

namespace leetCodeExamples.Solutions
{
    public class Stack
    {

        private int[] _stackValues;
        private const int arraySize = 10;
        private int top = -1; //bottom is always 0
        //FILO - > First in last out

        //Methods:


        public Stack()
        {
            _stackValues = new int[arraySize];

        }

        /// <summary>
        /// Adds number to stack
        /// </summary>
        /// <param name="newNumber"></param>
        public void Push(int newNumber)
        {

            if (top < _stackValues.Length - 1)   // Validation Stack is not overflowing
            {
                top++;
                _stackValues[top] = newNumber;

            }

        }

        // Peek - Get top

        public int Peek()
        {
            return _stackValues[top];
        }

        // Pop - Remove

        public void Pop()
        {
            // Find the top
            // Set it to null

            _stackValues[top] = 0;
            if (top > 0) top--;
        }

        // List

        public void List()
        {
            for (int i = 0; i < _stackValues.Length; ++i)
            {
                Console.Write($"{_stackValues[i]} ");
            }
            Console.WriteLine();
        }

        // Get Count
    }
}
