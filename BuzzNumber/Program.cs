using System;

namespace BuzzNumber
{
    class Program
    {
        static bool isBuzz(int num)
        {
            return (num % 10 == 7 || num % 7 == 0);
        }
        static void Main(string[] args)
        {
            int i=17; 
            int j=50;
            
            
            if (isBuzz(i))
            {
                Console.WriteLine("buzz number");
            }
            else
            {
                Console.WriteLine("not a buzz number");
            }
            if (isBuzz(j))
            {
                Console.WriteLine("buzz number");
            }
            else
            {
                Console.WriteLine("not a buzz number");
            }
        }

    }
}

