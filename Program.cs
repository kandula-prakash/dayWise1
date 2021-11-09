using System;

namespace pattrenDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.show();
            
            int  i, j;
            for ( i = 5; i >=1 ; i--)
            {
                for ( j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

         
        }
    }
}
public class demo
{
    public  void show()
    {
        int x, y;
        int z = 5;
        for ( x = 1; x <= z; x++)
        {
            for ( y = 1; y <= x; y++)
            {
                Console.Write((char)(x+64));
            }
            Console.WriteLine(" ");
        }
        Console.ReadLine();
    }
}
