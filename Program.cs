using System;

namespace armstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            primaryNumber p = new primaryNumber();
            p.PNO();
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
        }
    }
}

class primaryNumber
{
    public void PNO()
    {
       
        int ch, k;
        while (true)
        {
            Console.WriteLine("1.prime number");
            Console.WriteLine("2.palandrome number");
            Console.WriteLine("enter your choice");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                     Console.WriteLine("enter your number");
                    k =int.Parse (Console.ReadLine());
                    int d = 2;
                    Boolean b = true;
                    while (d <= k / 2)
                    {
                        if (k % d == 0)
                        {
                            b = false;
                            break;
                        }
                        d++;
                    }
                    if (b)
                    {
                        Console.WriteLine(k + " is a prime Number");
                    }
                    else
                    {
                        Console.WriteLine(k + " is not a prime Number");
                    }
                    break;
                case 2: Console.WriteLine("enter your number");
                    k = int.Parse(Console.ReadLine());
                    int rev = 0, temp = k;
                    while (temp > 0)
                    {
                        rev = (rev * 10) + (temp % 10);
                        temp /= 10;   // temp=temp/10
                    }
                    if (k == rev)
                    {
                        Console.WriteLine(k+"is palndrome number");
                    }
                    else
                    {
                        Console.WriteLine(k+"is not palndrome number");
                    }
                    break;
                    default:
                    Console.WriteLine("enter wrong number");
                    break;
            }
        }
    }
}
    

