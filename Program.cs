using System;

namespace pattrenA
{
    class Program
    {
        static void Main(string[] args)
        {
            demo b = new demo();
            demo1 c = new demo1();
            demo2 d = new demo2();
            demo3 e = new demo3();
            demo4 f = new demo4();
            demo5 g = new demo5();
            demoh H = new demoh();
            demo6 I = new demo6();
            demo7 J = new demo7();
            demo8 k = new demo8();
            demo9 L = new demo9();
            demo10 m = new demo10();
            demo11 n = new demo11();
            demo12 o = new demo12();
            demo13 p = new demo13();
            demo14 q = new demo14();
            demo15 r = new demo15();
            demo16 s = new demo16();
            demo17 t = new demo17();
            demo19 u = new demo19();
            demo18 v = new demo18();
          
            demo20 w = new demo20();
            demo21 x = new demo21();
            demo22 y = new demo22();
            demo23 z = new demo23();


            demo23 Z = new demo23();
            H.Hpattren();
            p.Ppattren();
            q.Qpattren();
            r.Rpattren();
            s.Spattren();
            t.Tpattren();
            u.Upattren();
            v.Vpattren();
            w.Wpattren();
            x.Xpattren();
            y.Ypattren();
            z.Zpattren();

           
            k.Kpattren();
            
            L.Lpattren();
           
            o.Opattren();
            n.Npattren();
            n.Npattren();
           
            z.Zpattren();
            m.Mpattren();
            J.Jpattren();
            I.Ipattren();
            g.Gpattren();
            f.Fpattren();
            e.Epattren();

            d.Dpattren();
            c.Cpattren();
            b.Bpattren();
            int i, j;
            for ( i = 1; i <= 5; i++)
            {
                for ( j = 1; j <=5; j++)
                {
                    if (i==1||i==3||j==1||j==5)
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
            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}

class demo
{
    public void Bpattren()
    {
        int i, j;
        for ( i = 1; i <=5; i++)
        {
            for ( j = 1; j <=5; j++)
            {
                if (i==1||i==3||i==5||j==1||j==5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo1
{
    public void Cpattren()
    {
        int i, j;
        for ( i = 1; i <=5; i++)
        {
            for ( j = 1; j <=5 ; j++)
            {
                if (i==1||i==5||j==1)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo2
{
    public void Dpattren()
    {
        int i ,j;
        for ( i = 1; i <=5; i++)
        {
            for ( j = 1; j <=5 ; j++)
            {
                if (i==1||i==5||j==1||j==5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo3
{
    public void Epattren()
    {
        int i, j;
        for ( i = 1; i <=5; i++)
        {
            for ( j = 1; j <= 5; j++)
            {
                if (i==1||i==3||i==5||j==1)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo4
{
    public void Fpattren()
    {
        int i, j;
        for ( i = 1; i <=5 ; i++)
        {
            for ( j = 1; j <=5 ; j++)
            {
                if (i==1||i==3||j==1)
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
        Console.WriteLine("\n---------------------------------------------");
    }

}
class demo5
{
    public void Gpattren()
    {
        int i, j;
        for ( i = 1; i <=5 ; i++)
        {
            for ( j = 1; j <=5 ; j++)
            {
                if (i==1||i==5||j==1||i==3 && j>=3||j==5&&i>=3)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demoh
{
    public void Hpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5||i==3)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}


class demo6
{
    public void Ipattren()
    {
        int i, j;
        for ( i = 1; i <=5 ; i++)
        {
            for ( j = 1; j <=5 ; j++)
            {
                if (i==1||i==5||j==3)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo7
{
    public void Jpattren()
    {
        int i, j;
        for ( i = 1; i <=5 ; i++)
        {
            for ( j = 1; j <=5; j++)
            {
                if (i==1||j==3||i==5&&j<=3||j==1&&i>=3)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo8
{
    public void Kpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || i==1&&j==5||i==2&&j==4||i==3&&j==3||j==3&&i==3||j==4&&i==4||j==5&&i==5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo9
{
    public void Lpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 5 || j == 1 )
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo10
{
    public void Mpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5 || i==2&&j==2||i==3&&j==3||i==2&&j==4)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo11
{
    public void Npattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || j == 5 ||i-j==0)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo12
{
    public void Opattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i==1&&j>=2&&j<=4||i==5&&j>=2&&j<=4||j==1&&i>=2&&i<=4||j==5&&i>=2&&i<=4)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo13
{
    public void Ppattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i==1||j==1||i==3||j==5&&i==2)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo14
{
    public void Qpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if ((i == 1 && j >= 2 && j <= 4) || i == 2 && j == 1 || i == 3 && j == 1 || i == 4 && j == 1
                        || (i == 5 && j >= 2 && j <= 5) || i == 2 && j == 5 || i == 3 && j == 5 || i == 4 && j >= 4)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo15
{
    public void Rpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j == 1 || i == 1 || i == 3 || i == 2 && j == 5 || i == 4 && j == 4 || i == 5 && j == 5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo16
    
{
    public void Spattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j >= 2 && i == 1 || i == 2 && j == 1 || i == 3 || i == 4 && j == 5 || j <= 4 && i == 5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo17
{
    public void Tpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i==1||j==3)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo18
{
    public void Vpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 9; j++)
            {
                if (i-j==0||i+j==10)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo19
{
    public void Upattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j==1||j==5||i==5&&j>=2&&j<=4)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}
class demo20
{
    public void Wpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (j==1||j==5||i==4&&j<=4&&j>=4||i==3&&j==3||i==4&&j<=2&&j>=2)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo21
{
    public void Xpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i-j==0||i+j==6)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo22
{
    public void Ypattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i == 1 && j == 1 || i == 2 && j == 2 || i == 3 && j == 3
                        || j == 5 && i == 1 || j == 4 && i == 2 || j == 3 && i == 3 || j == 2 && i == 4 || j == 1 && i == 5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}

class demo23
{
    public void Zpattren()
    {
        int i, j;
        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (i+j==6||i==1||i==5)
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
        Console.WriteLine("\n---------------------------------------------");
    }
}















