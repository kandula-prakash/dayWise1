using System;

namespace ploymerphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("finding the area of square\n");

            area a = new area();
            a.side = 5;
            a.findSquare();
            Console.WriteLine();

            area obj = new area();
            obj.side = 5;
            obj.findSquare();
            Console.ReadLine();
        }
    }
    class area
    {
        public int side { get; set; }

        public virtual void findSquare()
        {
            
            int areaOfTheSquare = side * side;
            Console.WriteLine("areaOfTheSquare"+ areaOfTheSquare);
        }
    }

     class side:area 
    {
        public override void findSquare()
        {
            int areaOfTheSquare = side * side;
            Console.WriteLine("areaOfTheSquare"+areaOfTheSquare);
        }
    }
}
