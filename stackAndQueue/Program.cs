using System;
using System.Collections;
using System.Collections.Concurrent;

namespace stackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack st = new Stack();
            st.Push("red");
            st.Push(25);
            st.Push(25.5);
            st.Push(true);
            st.Pop();

            foreach (var item in st)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine("number of elements are present:"+st.Count);


            Console.ReadLine();
            Console.ReadKey();
            demo();
            
        }
    }
}

class queue
{
    public static void demo()
    {
        Queue q = new Queue();
        q.Enqueue(5);
        q.Enqueue(6);
        q.Enqueue(7);
        q.Enqueue(8);
        q.Enqueue(9);
        foreach (var item in q)
        {
            Console.WriteLine(item);
        }
        Console.ReadKey();

    }
}
