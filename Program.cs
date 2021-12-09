using System;

namespace doubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL d = new DLL();
           
            d.push(10);
            d.push(20);
            d.push(30);
            d.push(40);
            d.AddLast(60);
            d.deleteAtFirst();
            
            d.findElement(20);
           
            d.display();
            d.insertSortedList(56);
            Console.WriteLine( "******************");
            d.display();

        }
    }
}
