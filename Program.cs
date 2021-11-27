using System;

namespace multileviInheritance
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Son s = new Son();
                s.Display();
                s.DisplayOne();
                s.DisplayTwo();
                Console.Read();
            }
        }
        class Grandfather
        {
            public void Display()
            {
                Console.WriteLine("Grandfather...");
            }
        }
        class Father : Grandfather
        {
            public void DisplayOne()
            {
                Console.WriteLine("Father...");
            }
        }
    class Son : Father
    {
        public void DisplayTwo()
        {
            Console.WriteLine("Son.. ");
        }

    }
}
