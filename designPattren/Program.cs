using System;

namespace designPattren
{
    class Program
    {
        static void Main(string[] args)
        {
            program1 p = new program1();
            prgm s = new prgm();
            prgm1 d = new prgm1();
            d.show1();
            s.show();
            p.pyramid();
            int i, j;
            for ( i = 0; i <=5 ; i++)
            {
                for ( j = 0; j <=8 ; j++)
                {
                    if (j>=i&&j<=8-i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
        }

    }
}
class program1
{
    public void pyramid()
    {
        int i, j;
        for (i = 0; i <= 5; i++)
        {
            for (j = 0; j <= 8; j++)
            {
                if (i >= j && i<=9 - j)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------");
    }

}


class prgm
{
    public void show()
    {
        int i, j;
        int k = 0;

        for (i = 1; i <= 7; i++)
        {
            var result = i <= 4 ? k++ : k--;
            for (j = 1; j <= 7; j++)
            {
                if ( j>=5-k&&j<=3+k)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------");
    }
}

class prgm1
{
    public void show1()
    {
        int i, j;
        int k = 0;

        for (i = 1; i <= 9; i++)
        {
            var result = i <=5 ? k++ : k--;
            for (j = 1; j <= 9; j++)
            {
                if (j<=6-k||j>=4+k)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("----------------------------");
    }
}
