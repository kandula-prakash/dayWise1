using System;

namespace linkedListDemoBRP
{
    class Program
    {
        static void Main(string[] args)
        {
            singleLinedList s = new singleLinedList();
            s.AddEmptyList(20);
            s.AddLast(40);
            s.begining(30);
            int x;
            Console.WriteLine("enter the postion");
            x = int.Parse(Console.ReadLine());
            s.AtPosition(10, 2);
            s.AddBefore(40, 3);
            s.deleteFirst();
            
            s.Display();

        }
    }
}
