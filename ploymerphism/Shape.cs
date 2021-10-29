using System;
using System.Collections.Generic;
using System.Text;

namespace ploymerphism
{
    class milk
    {
        public virtual void Draw()
        {

        }
    }
    class curd : milk
    {
        public override void Draw()
        {
            Console.WriteLine("curd Deawn");
        }
    }
    class butterMilk : milk
    {
        public override void Draw()
        {
            Console.WriteLine("butterMilk Drawn");
        }
    }
    class ghee : milk
    {
        public override void Draw()
        {
            Console.WriteLine("ghee draw");
        }
    }

    class shape
    {
       // static void Main(string[] args)
        {
            milk[] m = new milk[2];
            m[0] = new ghee();
            m[1] = new butterMilk();
            Console.WriteLine("\n\n runtime polymorphism test\n\n");
            for (int i = 0; i < 2; i++)
            {
                m[i].Draw();
            }
            Console.ReadKey();
        }

    }
}
