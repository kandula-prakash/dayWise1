using System;
using System.Collections.Generic;
using System.Text;

namespace AutomorphicProgram
{
    class buzzNumber
    {
        static bool isBuzz(int num)
        {
            return (num % 10 == 7 || num % 7 == 0);
        }
        public static void Main()
        {
            int i = 67, j = 19;
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
