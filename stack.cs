using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace stackBRP
{
    class stack
    {
        private int MAX = 100;
        private int top;
       public int[] Stack;

        public stack()
        {
            Stack = new int[MAX];
            top = -1;
        }

        public void isEmpty()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("Stack is not empty.");
            }
        }


        public int size()
        {
            return top + 1;
        }

        public void push(int x)
        {
            if (top == (MAX - 1))
            {
                Console.WriteLine("Stack size limit reached.");
            }
            else
            {
                Stack[++top] = x;
                Console.WriteLine(x + " is added into the stack.");
            }
        }

        public void pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                int x = Stack[top--];
                Console.WriteLine(x + " is deleted from the stack.");
            }
        }

        public int topElement()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack is empty.");
                return 0;
            }
            else
            {
                return Stack[top];
            }
        }

    }
}
