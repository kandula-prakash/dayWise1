using System;

namespace lamdaExpression
{
    class Program
    {
        public delegate string WishDelegate(string name);
      
        static void Main(string[] args)
        {
          
            WishDelegate wd = (name) =>
            {
                return "hello Mr." + name + "have a nice day";
            };
            string WishDelegate = wd.Invoke("manikanta");
            Console.WriteLine(WishDelegate);
            Console.ReadKey();

          //  WishDelegate wd = Program.sayhello;
        }
    }
}
