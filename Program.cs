using System;

namespace swapingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            program1 p = new program1();
            program2 p2 = new program2();
            program3 p3 = new program3();
            p3.show2();
            p2.show1();
            p.show();
            int a=10, b=54, temp=0;
            
            Console.WriteLine($"before swaping the elements a={a},b={ b}");
            
          

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"after the swapping the elemets a={a},b={b}");
            Console.ReadKey();
            
        }
    }
}
class program1
{
    public void show()
    {
        int val1 = 100;
        int val2 = 200;
        Console.WriteLine("before swaping the numbers");
        Console.WriteLine( val1.ToString());
        Console.WriteLine(val2.ToString());

        val1 = val1 + val2;
        val2 = val1 - val2;
        val1 = val1 - val2;
        Console.WriteLine("after swaping the numbers");
        Console.WriteLine(val1.ToString());
        Console.WriteLine(val2.ToString());
        Console.ReadKey();
    }
}

class program2
{
    public void show1()
    {
        int num1, num2;
        num1 = 24;
        num2 = 42;
        Console.WriteLine("before swaping numbers");
        Console.WriteLine(num1.ToString());
        Console.WriteLine(num2.ToString());
       

        num1 = num1 ^num2;
        num2 = num1  ^num2;
        num1 = num1 ^ num2;
        Console.WriteLine("after swaping the numbers");
        Console.WriteLine(num1.ToString());
        Console.WriteLine(num2.ToString());
        Console.ReadKey();

    }
}
class program3
{
    public void show2()
    {
        int x, y;
        x = 54;
        y = 98;
        Console.WriteLine("before swaping numbers");
        Console.WriteLine(x.ToString());
        Console.WriteLine(y.ToString());
        x = y - x + (y = x);
        Console.WriteLine("after swaping the numbers");
        Console.WriteLine(x.ToString());
        Console.WriteLine(y.ToString());
        Console.ReadKey();
    }
}
