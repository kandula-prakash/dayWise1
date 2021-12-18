using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            al.Add(60);

            al.Add("prakash");
            al.Add("amith");
            al.Add("seetha");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("******************");
            //remove method
            al.Remove(10);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*****************");
            al.RemoveAt(5);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            al.RemoveRange(1, 3);
            Console.WriteLine("*****************");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.Write("content: ");
            al.Sort();
            foreach (var item in al)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();




        }
    }
}
