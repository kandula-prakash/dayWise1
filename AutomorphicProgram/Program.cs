using System;

namespace AutomorphicProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            if (checkAutomorphicNumber(num))
            {
                Console.WriteLine("Automorphic Number");
            }
            else
            {
                Console.WriteLine("not Automoprhic number");
            }
            Console.ReadLine();
        }
        public static bool checkAutomorphicNumber(int no)
        {
            int square = no * no;
            while (no>0)
            {
                if (no % 10 != square % 10)
                {
                    return false;
                }
                no = no / 10;
                square = square / 10;
            }
            return true;
        }
       
    }
}
