using System;

namespace daywiseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<=100)
            {
                int y = 2;
                while (y<=x)
                {
                    if (x==y)
                    {
                        Console.WriteLine(x);
                    }
                    if (x%y==0)
                    {
                        break;
                    }
                    y++;
                }
                x++;
            }
            
            Console.ReadLine();
        }
    }
}
        
    

