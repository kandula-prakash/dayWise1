using System;

namespace logicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            pgm p = new pgm();
            p.show();
            pgm2 d = new pgm2();
            d.demo();
            
            for ( int i = 1;  i <= 100;  i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("even numbers is:{0}",i);
                    
                }
               
                
            }
            Console.ReadKey();
            Console.WriteLine("****************************************");
        }

    }
}
class pgm
{
    public void show()
    {
        for (int j = 4; j <= 49; j++)
        {
            if (j % 2 != 0)
            {
                Console.WriteLine("odd number is:{0}",j);
                
            }
        }
        Console.ReadKey();
        Console.WriteLine("****************************************");
    }
}
class pgm2
{
    public  void demo()
    {
        Console.WriteLine("enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        if ((number/2)*2==number)
        {
            Console.WriteLine("even number{0}",number);

        }
        else
        {
            Console.WriteLine("given number is odd{0}",number);
        }
        Console.ReadKey();
        Console.WriteLine("****************************************");
    }
   
}
