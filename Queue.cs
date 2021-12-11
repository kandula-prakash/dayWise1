using System;
using System.Collections.Generic;
using System.Text;

namespace stackBRP
{
    class Queue
    {
        public int Max = 10;
        public int front;
        public int rear;
        public int[] queue;

        public Queue()
        {
            queue = new int[Max];
            front = -1;
            rear = -1;
        }
        public void isEmpty()
        {
            if (rear == front)
                Console.WriteLine("Queue is empty");
        }
        public void display()
        {
            if (front==-1&&rear==-1)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                for (int i =front; i <= rear; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void EnQueue(int x)
        {
            if (rear == (Max - 1))
                Console.WriteLine("Queue size limit is reached");
            else
            {
                queue[++rear] = x;
                Console.WriteLine(x + "is added into Queue");
            }
        }
        public void DeQueue()
        {
            if (rear == front)
                Console.WriteLine("Queue is empty");
            else
            {
                int x = queue[++front];
                Console.WriteLine(x + "is deleted from Queue");
            }
        }
    }
 
}
